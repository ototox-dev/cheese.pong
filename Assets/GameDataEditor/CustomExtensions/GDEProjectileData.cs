// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by the Game Data Editor.
//
//      Changes to this file will be lost if the code is regenerated.
//
//      This file was generated from this data file:
//      Assets/GameDataEditor/Resources/gde_data.txt
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections.Generic;

using GameDataEditor;

namespace GameDataEditor
{
    public class GDEProjectileData : IGDEData
    {
        static string shapePathKey = "shapePath";
		string _shapePath;
        public string shapePath
        {
            get { return _shapePath; }
            set {
                if (_shapePath != value)
                {
                    _shapePath = value;
					GDEDataManager.SetString(_key, shapePathKey, _shapePath);
                }
            }
        }

        static string fsmPathKey = "fsmPath";
		string _fsmPath;
        public string fsmPath
        {
            get { return _fsmPath; }
            set {
                if (_fsmPath != value)
                {
                    _fsmPath = value;
					GDEDataManager.SetString(_key, fsmPathKey, _fsmPath);
                }
            }
        }

        static string localScaleKey = "localScale";
		Vector3 _localScale;
        public Vector3 localScale
        {
            get { return _localScale; }
            set {
                if (_localScale != value)
                {
                    _localScale = value;
					GDEDataManager.SetVector3(_key, localScaleKey, _localScale);
                }
            }
        }

        public GDEProjectileData(string key) : base(key)
        {
            GDEDataManager.RegisterItem(this.SchemaName(), key);
        }
        public override Dictionary<string, object> SaveToDict()
		{
			var dict = new Dictionary<string, object>();
			dict.Add(GDMConstants.SchemaKey, "Projectile");
			
            dict.Merge(true, shapePath.ToGDEDict(shapePathKey));
            dict.Merge(true, fsmPath.ToGDEDict(fsmPathKey));
            dict.Merge(true, localScale.ToGDEDict(localScaleKey));
            return dict;
		}

        public override void UpdateCustomItems(bool rebuildKeyList)
        {
        }

        public override void LoadFromDict(string dataKey, Dictionary<string, object> dict)
        {
            _key = dataKey;

			if (dict == null)
				LoadFromSavedData(dataKey);
			else
			{
                dict.TryGetString(shapePathKey, out _shapePath);
                dict.TryGetString(fsmPathKey, out _fsmPath);
                dict.TryGetVector3(localScaleKey, out _localScale);
                LoadFromSavedData(dataKey);
			}
		}

        public override void LoadFromSavedData(string dataKey)
		{
			_key = dataKey;
			
            _shapePath = GDEDataManager.GetString(_key, shapePathKey, _shapePath);
            _fsmPath = GDEDataManager.GetString(_key, fsmPathKey, _fsmPath);
            _localScale = GDEDataManager.GetVector3(_key, localScaleKey, _localScale);
        }

        public GDEProjectileData ShallowClone()
		{
			string newKey = Guid.NewGuid().ToString();
			GDEProjectileData newClone = new GDEProjectileData(newKey);

            newClone.shapePath = shapePath;
            newClone.fsmPath = fsmPath;
            newClone.localScale = localScale;

            return newClone;
		}

        public GDEProjectileData DeepClone()
		{
			GDEProjectileData newClone = ShallowClone();
            return newClone;
		}

        public void Reset_shapePath()
        {
            GDEDataManager.ResetToDefault(_key, shapePathKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(shapePathKey, out _shapePath);
        }

        public void Reset_fsmPath()
        {
            GDEDataManager.ResetToDefault(_key, fsmPathKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(fsmPathKey, out _fsmPath);
        }

        public void Reset_localScale()
        {
            GDEDataManager.ResetToDefault(_key, localScaleKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetVector3(localScaleKey, out _localScale);
        }

        public void ResetAll()
        {
            GDEDataManager.ResetToDefault(_key, shapePathKey);
            GDEDataManager.ResetToDefault(_key, localScaleKey);
            GDEDataManager.ResetToDefault(_key, fsmPathKey);


            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            LoadFromDict(_key, dict);
        }
    }
}
