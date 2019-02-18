﻿// Copyright 2018 Jeremy Cowles. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.IO;
using UnityEngine;
using USD.NET;

namespace Unity.Formats.USD {
  public class UsdzExporter {

    public static void ExportUsdz(string usdzFilePath,
                                  GameObject root) {
      // Setup a temp directory for zipping up files.
      string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
      var tmpUsdName = Path.GetFileNameWithoutExtension(usdzFilePath);
      var di = Directory.CreateDirectory(tempDirectory);
      var tmpUsdFilePath = Path.Combine(tempDirectory, tmpUsdName + ".usd");
      var curDir = Directory.GetCurrentDirectory();

      // Create the temp .usd scene, into which the data will be exported.
      var scene = InitForSave(tmpUsdFilePath);

      try {
        try {
          // Set the current working directory to the USDZ directory so the paths in USD
          // will be relative.
          Directory.SetCurrentDirectory(tempDirectory);

          // Export the temp scene.
          SceneExporter.Export(root,
                               scene,
                               BasisTransformation.SlowAndSafe,
                               exportUnvarying: true,
                               zeroRootTransform: false,
                               exportMaterials: true);
        } finally {
          // Flush any in-flight edits and release the scene so the file can be deleted.
          scene.Save();
          scene.Close();
          scene = null;
        }

        // Copy resulting files into the USDZ archive.
        var filesToArchive = new pxr.StdStringVector();
        foreach (var fileInfo in di.GetFiles()) {
          var relPath = ImporterBase.MakeRelativePath(tmpUsdFilePath, fileInfo.FullName);
          Debug.Log(relPath);
          filesToArchive.Add(relPath);
        }

        // Write the USDZ file.
        pxr.UsdCs.WriteUsdZip(usdzFilePath, filesToArchive);
      } finally {
        // Clean up temp files.
        Directory.SetCurrentDirectory(curDir);
        di.Delete(recursive: true);
      }
    }

    private static Scene InitForSave(string filePath) {
      var fileDir = Path.GetDirectoryName(filePath);

      if (!Directory.Exists(fileDir)) {
        var di = Directory.CreateDirectory(fileDir);
        if (!di.Exists) {
          Debug.LogError("Failed to create directory: " + fileDir);
          return null;
        }
      }

      InitUsd.Initialize();
      var scene = Scene.Create(filePath);
      scene.Time = 0;
      scene.StartTime = 0;
      scene.EndTime = 0;
      return scene;
    }

  }
}