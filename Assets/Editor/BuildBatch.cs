using UnityEngine;
using UnityEditor;

using System.Collections;

public class BuildBatch : MonoBehaviour {
	
	[UnityEditor.MenuItem("Tools/Build Project AllScene Android")]
	public static void BuildProjectAllSceneAndroid() {
		EditorUserBuildSettings.SwitchActiveBuildTarget (BuildTarget.Android);
		string[] allScene = new string[EditorBuildSettings.scenes.Length];
		int i = 0;
		foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes) {
			allScene[i] = scene.path;
			i++;
		}
		PlayerSettings.bundleIdentifier = "com.nagizero.cube";
		PlayerSettings.statusBarHidden = true;
		BuildPipeline.BuildPlayer( allScene,
		                          "cube.apk",
		                          BuildTarget.Android,
		                          BuildOptions.None
		                          );
	}
}
