// Copyright 2018 Jeremy Cowles. All rights reserved.
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

using System;
using USD.NET;
using USD.NET.Unity;

[System.Serializable]
[UsdSchema("UsdGeomXformable")]
class XformableSample : SampleBase {
  public XformableSample() {
  }
}

[System.Serializable]
[UsdSchema("BOGUS_TYPE_INTENDED_TO_THROW_ERROR")]
class BadBaseTypeQuery : SampleBase {
  public BadBaseTypeQuery() {
  }
}

namespace Tests.Cases {
  class QueryTests : UnitTest {

    public static void BasicTest() {

      var xform1Sample = new XformableSample();
      var xform2Sample = new XformableSample();
      var scene = Scene.Create();

      scene.Write("/Root/Xform1", xform1Sample);
      scene.Write("/Root/Xform2", xform2Sample);

      foreach (var xformables in scene.ReadAll<XformableSample>(rootPath:"/Root")) {
        Console.WriteLine("ReadAll Test: " + xforms.path);
      }

      foreach (var path in scene.Find<XformableSample>(rootPath: "/Root")) {
        Console.WriteLine("Find Test: " + path);
      }

      try {
        Util.DiagnosticHandler.Instance.LastError = null;

        foreach (var xformables in scene.ReadAll<XformableSample>(rootPath: "/Bogus/Root/Path")) {
          Console.WriteLine("Query Test: " + mesh.path);
        }

        // TODO: for some reason, these stop working after the first exception is thrown,
        //       but it seems like *only* this code path is affected.
        if (!string.IsNullOrEmpty(Util.DiagnosticHandler.Instance.LastError)) {
          throw new ApplicationException(Util.DiagnosticHandler.Instance.LastError);
        } else {
          throw new Exception("Expected exception but was not thrown.");
        }

      } catch (ApplicationException ex) {
        Console.WriteLine("Caught expected exception: " + ex.Message);
      }

      try {
        Util.DiagnosticHandler.Instance.LastError = null;

        foreach (var mesh in scene.ReadAll<BadBaseTypeQuery>(rootPath: "/Root")) {
          Console.WriteLine("Query Test: " + mesh.path);
        }
        
        // TODO: for some reason, these stop working after the first exception is thrown,
        //       but it seems like *only* this code path is affected.
        if (!string.IsNullOrEmpty(Util.DiagnosticHandler.Instance.LastError)) {
          throw new ApplicationException(Util.DiagnosticHandler.Instance.LastError);
        } else {
          throw new Exception("Expected exception but was not thrown.");
        }

      } catch (ApplicationException ex) {
        Console.WriteLine("Caught expected exception: " + ex.Message);
      }
    }

  }
}
