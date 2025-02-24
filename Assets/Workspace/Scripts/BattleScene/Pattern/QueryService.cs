using UnityEditor;
using UnityEngine;

public abstract class QueryService<T, U> where T : DataBase<U> where U : Data
{
	private const string DATABASE_BASE_PATH = "Assets/Workspace/Level/Database/";
	private const string EXTENTION = ".asset";

	protected T LoadDatabase(string databaseName) {
		var database = AssetDatabase.LoadAssetAtPath<T>(DATABASE_BASE_PATH +  databaseName + EXTENTION);

		try {
			if (database == null) {
				throw new System.Exception($"データベースファイルが存在しません: databaseName {databaseName}, path: {DATABASE_BASE_PATH + databaseName}");
			}
		} catch(System.Exception e) {
			Debug.LogError($"Error has occurred in QueryService.LoadDatabase: {e.Message}");
		}
		return database;
	}

	public abstract U FetchByName(string name);
}
