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
    public class GDETacoData : IGDEData
    {
        static string hideHairKey = "hideHair";
		bool _hideHair;
        public bool hideHair
        {
            get { return _hideHair; }
            set {
                if (_hideHair != value)
                {
                    _hideHair = value;
					GDEDataManager.SetBool(_key, hideHairKey, _hideHair);
                }
            }
        }

        static string requireWeightKey = "requireWeight";
		int _requireWeight;
        public int requireWeight
        {
            get { return _requireWeight; }
            set {
                if (_requireWeight != value)
                {
                    _requireWeight = value;
					GDEDataManager.SetInt(_key, requireWeightKey, _requireWeight);
                }
            }
        }

        static string healthPointKey = "healthPoint";
		int _healthPoint;
        public int healthPoint
        {
            get { return _healthPoint; }
            set {
                if (_healthPoint != value)
                {
                    _healthPoint = value;
					GDEDataManager.SetInt(_key, healthPointKey, _healthPoint);
                }
            }
        }

        static string atkBonusKey = "atkBonus";
		int _atkBonus;
        public int atkBonus
        {
            get { return _atkBonus; }
            set {
                if (_atkBonus != value)
                {
                    _atkBonus = value;
					GDEDataManager.SetInt(_key, atkBonusKey, _atkBonus);
                }
            }
        }

        static string defBonusKey = "defBonus";
		int _defBonus;
        public int defBonus
        {
            get { return _defBonus; }
            set {
                if (_defBonus != value)
                {
                    _defBonus = value;
					GDEDataManager.SetInt(_key, defBonusKey, _defBonus);
                }
            }
        }

        static string dmgClampMinKey = "dmgClampMin";
		int _dmgClampMin;
        public int dmgClampMin
        {
            get { return _dmgClampMin; }
            set {
                if (_dmgClampMin != value)
                {
                    _dmgClampMin = value;
					GDEDataManager.SetInt(_key, dmgClampMinKey, _dmgClampMin);
                }
            }
        }

        static string dmgClampMaxKey = "dmgClampMax";
		int _dmgClampMax;
        public int dmgClampMax
        {
            get { return _dmgClampMax; }
            set {
                if (_dmgClampMax != value)
                {
                    _dmgClampMax = value;
					GDEDataManager.SetInt(_key, dmgClampMaxKey, _dmgClampMax);
                }
            }
        }

        static string dmgCountKey = "dmgCount";
		int _dmgCount;
        public int dmgCount
        {
            get { return _dmgCount; }
            set {
                if (_dmgCount != value)
                {
                    _dmgCount = value;
					GDEDataManager.SetInt(_key, dmgCountKey, _dmgCount);
                }
            }
        }

        static string populationKey = "population";
		float _population;
        public float population
        {
            get { return _population; }
            set {
                if (_population != value)
                {
                    _population = value;
					GDEDataManager.SetFloat(_key, populationKey, _population);
                }
            }
        }

        static string speedBonusKey = "speedBonus";
		float _speedBonus;
        public float speedBonus
        {
            get { return _speedBonus; }
            set {
                if (_speedBonus != value)
                {
                    _speedBonus = value;
					GDEDataManager.SetFloat(_key, speedBonusKey, _speedBonus);
                }
            }
        }

        static string visionRangeKey = "visionRange";
		float _visionRange;
        public float visionRange
        {
            get { return _visionRange; }
            set {
                if (_visionRange != value)
                {
                    _visionRange = value;
					GDEDataManager.SetFloat(_key, visionRangeKey, _visionRange);
                }
            }
        }

        static string atkRangeKey = "atkRange";
		float _atkRange;
        public float atkRange
        {
            get { return _atkRange; }
            set {
                if (_atkRange != value)
                {
                    _atkRange = value;
					GDEDataManager.SetFloat(_key, atkRangeKey, _atkRange);
                }
            }
        }

        static string atkSpeedKey = "atkSpeed";
		float _atkSpeed;
        public float atkSpeed
        {
            get { return _atkSpeed; }
            set {
                if (_atkSpeed != value)
                {
                    _atkSpeed = value;
					GDEDataManager.SetFloat(_key, atkSpeedKey, _atkSpeed);
                }
            }
        }

        static string weightRobRateKey = "weightRobRate";
		float _weightRobRate;
        public float weightRobRate
        {
            get { return _weightRobRate; }
            set {
                if (_weightRobRate != value)
                {
                    _weightRobRate = value;
					GDEDataManager.SetFloat(_key, weightRobRateKey, _weightRobRate);
                }
            }
        }

        static string nickNameKey = "nickName";
		string _nickName;
        public string nickName
        {
            get { return _nickName; }
            set {
                if (_nickName != value)
                {
                    _nickName = value;
					GDEDataManager.SetString(_key, nickNameKey, _nickName);
                }
            }
        }

        static string raceNameKey = "raceName";
		string _raceName;
        public string raceName
        {
            get { return _raceName; }
            set {
                if (_raceName != value)
                {
                    _raceName = value;
					GDEDataManager.SetString(_key, raceNameKey, _raceName);
                }
            }
        }

        static string ownerNameKey = "ownerName";
		string _ownerName;
        public string ownerName
        {
            get { return _ownerName; }
            set {
                if (_ownerName != value)
                {
                    _ownerName = value;
					GDEDataManager.SetString(_key, ownerNameKey, _ownerName);
                }
            }
        }

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

        static string leftWeaponDataKey = "leftWeaponData";
		string _leftWeaponData;
        public string leftWeaponData
        {
            get { return _leftWeaponData; }
            set {
                if (_leftWeaponData != value)
                {
                    _leftWeaponData = value;
					GDEDataManager.SetString(_key, leftWeaponDataKey, _leftWeaponData);
                }
            }
        }

        static string rightWeaponDataKey = "rightWeaponData";
		string _rightWeaponData;
        public string rightWeaponData
        {
            get { return _rightWeaponData; }
            set {
                if (_rightWeaponData != value)
                {
                    _rightWeaponData = value;
					GDEDataManager.SetString(_key, rightWeaponDataKey, _rightWeaponData);
                }
            }
        }

        static string animPathKey = "animPath";
		string _animPath;
        public string animPath
        {
            get { return _animPath; }
            set {
                if (_animPath != value)
                {
                    _animPath = value;
					GDEDataManager.SetString(_key, animPathKey, _animPath);
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

        public GDETacoData(string key) : base(key)
        {
            GDEDataManager.RegisterItem(this.SchemaName(), key);
        }
        public override Dictionary<string, object> SaveToDict()
		{
			var dict = new Dictionary<string, object>();
			dict.Add(GDMConstants.SchemaKey, "Taco");
			
            dict.Merge(true, hideHair.ToGDEDict(hideHairKey));
            dict.Merge(true, requireWeight.ToGDEDict(requireWeightKey));
            dict.Merge(true, healthPoint.ToGDEDict(healthPointKey));
            dict.Merge(true, atkBonus.ToGDEDict(atkBonusKey));
            dict.Merge(true, defBonus.ToGDEDict(defBonusKey));
            dict.Merge(true, dmgClampMin.ToGDEDict(dmgClampMinKey));
            dict.Merge(true, dmgClampMax.ToGDEDict(dmgClampMaxKey));
            dict.Merge(true, dmgCount.ToGDEDict(dmgCountKey));
            dict.Merge(true, population.ToGDEDict(populationKey));
            dict.Merge(true, speedBonus.ToGDEDict(speedBonusKey));
            dict.Merge(true, visionRange.ToGDEDict(visionRangeKey));
            dict.Merge(true, atkRange.ToGDEDict(atkRangeKey));
            dict.Merge(true, atkSpeed.ToGDEDict(atkSpeedKey));
            dict.Merge(true, weightRobRate.ToGDEDict(weightRobRateKey));
            dict.Merge(true, nickName.ToGDEDict(nickNameKey));
            dict.Merge(true, raceName.ToGDEDict(raceNameKey));
            dict.Merge(true, ownerName.ToGDEDict(ownerNameKey));
            dict.Merge(true, shapePath.ToGDEDict(shapePathKey));
            dict.Merge(true, leftWeaponData.ToGDEDict(leftWeaponDataKey));
            dict.Merge(true, rightWeaponData.ToGDEDict(rightWeaponDataKey));
            dict.Merge(true, animPath.ToGDEDict(animPathKey));
            dict.Merge(true, fsmPath.ToGDEDict(fsmPathKey));
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
                dict.TryGetBool(hideHairKey, out _hideHair);
                dict.TryGetInt(requireWeightKey, out _requireWeight);
                dict.TryGetInt(healthPointKey, out _healthPoint);
                dict.TryGetInt(atkBonusKey, out _atkBonus);
                dict.TryGetInt(defBonusKey, out _defBonus);
                dict.TryGetInt(dmgClampMinKey, out _dmgClampMin);
                dict.TryGetInt(dmgClampMaxKey, out _dmgClampMax);
                dict.TryGetInt(dmgCountKey, out _dmgCount);
                dict.TryGetFloat(populationKey, out _population);
                dict.TryGetFloat(speedBonusKey, out _speedBonus);
                dict.TryGetFloat(visionRangeKey, out _visionRange);
                dict.TryGetFloat(atkRangeKey, out _atkRange);
                dict.TryGetFloat(atkSpeedKey, out _atkSpeed);
                dict.TryGetFloat(weightRobRateKey, out _weightRobRate);
                dict.TryGetString(nickNameKey, out _nickName);
                dict.TryGetString(raceNameKey, out _raceName);
                dict.TryGetString(ownerNameKey, out _ownerName);
                dict.TryGetString(shapePathKey, out _shapePath);
                dict.TryGetString(leftWeaponDataKey, out _leftWeaponData);
                dict.TryGetString(rightWeaponDataKey, out _rightWeaponData);
                dict.TryGetString(animPathKey, out _animPath);
                dict.TryGetString(fsmPathKey, out _fsmPath);
                LoadFromSavedData(dataKey);
			}
		}

        public override void LoadFromSavedData(string dataKey)
		{
			_key = dataKey;
			
            _hideHair = GDEDataManager.GetBool(_key, hideHairKey, _hideHair);
            _requireWeight = GDEDataManager.GetInt(_key, requireWeightKey, _requireWeight);
            _healthPoint = GDEDataManager.GetInt(_key, healthPointKey, _healthPoint);
            _atkBonus = GDEDataManager.GetInt(_key, atkBonusKey, _atkBonus);
            _defBonus = GDEDataManager.GetInt(_key, defBonusKey, _defBonus);
            _dmgClampMin = GDEDataManager.GetInt(_key, dmgClampMinKey, _dmgClampMin);
            _dmgClampMax = GDEDataManager.GetInt(_key, dmgClampMaxKey, _dmgClampMax);
            _dmgCount = GDEDataManager.GetInt(_key, dmgCountKey, _dmgCount);
            _population = GDEDataManager.GetFloat(_key, populationKey, _population);
            _speedBonus = GDEDataManager.GetFloat(_key, speedBonusKey, _speedBonus);
            _visionRange = GDEDataManager.GetFloat(_key, visionRangeKey, _visionRange);
            _atkRange = GDEDataManager.GetFloat(_key, atkRangeKey, _atkRange);
            _atkSpeed = GDEDataManager.GetFloat(_key, atkSpeedKey, _atkSpeed);
            _weightRobRate = GDEDataManager.GetFloat(_key, weightRobRateKey, _weightRobRate);
            _nickName = GDEDataManager.GetString(_key, nickNameKey, _nickName);
            _raceName = GDEDataManager.GetString(_key, raceNameKey, _raceName);
            _ownerName = GDEDataManager.GetString(_key, ownerNameKey, _ownerName);
            _shapePath = GDEDataManager.GetString(_key, shapePathKey, _shapePath);
            _leftWeaponData = GDEDataManager.GetString(_key, leftWeaponDataKey, _leftWeaponData);
            _rightWeaponData = GDEDataManager.GetString(_key, rightWeaponDataKey, _rightWeaponData);
            _animPath = GDEDataManager.GetString(_key, animPathKey, _animPath);
            _fsmPath = GDEDataManager.GetString(_key, fsmPathKey, _fsmPath);
        }

        public GDETacoData ShallowClone()
		{
			string newKey = Guid.NewGuid().ToString();
			GDETacoData newClone = new GDETacoData(newKey);

            newClone.hideHair = hideHair;
            newClone.requireWeight = requireWeight;
            newClone.healthPoint = healthPoint;
            newClone.atkBonus = atkBonus;
            newClone.defBonus = defBonus;
            newClone.dmgClampMin = dmgClampMin;
            newClone.dmgClampMax = dmgClampMax;
            newClone.dmgCount = dmgCount;
            newClone.population = population;
            newClone.speedBonus = speedBonus;
            newClone.visionRange = visionRange;
            newClone.atkRange = atkRange;
            newClone.atkSpeed = atkSpeed;
            newClone.weightRobRate = weightRobRate;
            newClone.nickName = nickName;
            newClone.raceName = raceName;
            newClone.ownerName = ownerName;
            newClone.shapePath = shapePath;
            newClone.leftWeaponData = leftWeaponData;
            newClone.rightWeaponData = rightWeaponData;
            newClone.animPath = animPath;
            newClone.fsmPath = fsmPath;

            return newClone;
		}

        public GDETacoData DeepClone()
		{
			GDETacoData newClone = ShallowClone();
            return newClone;
		}

        public void Reset_hideHair()
        {
            GDEDataManager.ResetToDefault(_key, hideHairKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetBool(hideHairKey, out _hideHair);
        }

        public void Reset_requireWeight()
        {
            GDEDataManager.ResetToDefault(_key, requireWeightKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(requireWeightKey, out _requireWeight);
        }

        public void Reset_healthPoint()
        {
            GDEDataManager.ResetToDefault(_key, healthPointKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(healthPointKey, out _healthPoint);
        }

        public void Reset_atkBonus()
        {
            GDEDataManager.ResetToDefault(_key, atkBonusKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(atkBonusKey, out _atkBonus);
        }

        public void Reset_defBonus()
        {
            GDEDataManager.ResetToDefault(_key, defBonusKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(defBonusKey, out _defBonus);
        }

        public void Reset_dmgClampMin()
        {
            GDEDataManager.ResetToDefault(_key, dmgClampMinKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(dmgClampMinKey, out _dmgClampMin);
        }

        public void Reset_dmgClampMax()
        {
            GDEDataManager.ResetToDefault(_key, dmgClampMaxKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(dmgClampMaxKey, out _dmgClampMax);
        }

        public void Reset_dmgCount()
        {
            GDEDataManager.ResetToDefault(_key, dmgCountKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(dmgCountKey, out _dmgCount);
        }

        public void Reset_population()
        {
            GDEDataManager.ResetToDefault(_key, populationKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(populationKey, out _population);
        }

        public void Reset_speedBonus()
        {
            GDEDataManager.ResetToDefault(_key, speedBonusKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(speedBonusKey, out _speedBonus);
        }

        public void Reset_visionRange()
        {
            GDEDataManager.ResetToDefault(_key, visionRangeKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(visionRangeKey, out _visionRange);
        }

        public void Reset_atkRange()
        {
            GDEDataManager.ResetToDefault(_key, atkRangeKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(atkRangeKey, out _atkRange);
        }

        public void Reset_atkSpeed()
        {
            GDEDataManager.ResetToDefault(_key, atkSpeedKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(atkSpeedKey, out _atkSpeed);
        }

        public void Reset_weightRobRate()
        {
            GDEDataManager.ResetToDefault(_key, weightRobRateKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetFloat(weightRobRateKey, out _weightRobRate);
        }

        public void Reset_nickName()
        {
            GDEDataManager.ResetToDefault(_key, nickNameKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(nickNameKey, out _nickName);
        }

        public void Reset_raceName()
        {
            GDEDataManager.ResetToDefault(_key, raceNameKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(raceNameKey, out _raceName);
        }

        public void Reset_ownerName()
        {
            GDEDataManager.ResetToDefault(_key, ownerNameKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(ownerNameKey, out _ownerName);
        }

        public void Reset_shapePath()
        {
            GDEDataManager.ResetToDefault(_key, shapePathKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(shapePathKey, out _shapePath);
        }

        public void Reset_leftWeaponData()
        {
            GDEDataManager.ResetToDefault(_key, leftWeaponDataKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(leftWeaponDataKey, out _leftWeaponData);
        }

        public void Reset_rightWeaponData()
        {
            GDEDataManager.ResetToDefault(_key, rightWeaponDataKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(rightWeaponDataKey, out _rightWeaponData);
        }

        public void Reset_animPath()
        {
            GDEDataManager.ResetToDefault(_key, animPathKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(animPathKey, out _animPath);
        }

        public void Reset_fsmPath()
        {
            GDEDataManager.ResetToDefault(_key, fsmPathKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(fsmPathKey, out _fsmPath);
        }

        public void ResetAll()
        {
            GDEDataManager.ResetToDefault(_key, nickNameKey);
            GDEDataManager.ResetToDefault(_key, raceNameKey);
            GDEDataManager.ResetToDefault(_key, ownerNameKey);
            GDEDataManager.ResetToDefault(_key, shapePathKey);
            GDEDataManager.ResetToDefault(_key, leftWeaponDataKey);
            GDEDataManager.ResetToDefault(_key, rightWeaponDataKey);
            GDEDataManager.ResetToDefault(_key, hideHairKey);
            GDEDataManager.ResetToDefault(_key, requireWeightKey);
            GDEDataManager.ResetToDefault(_key, populationKey);
            GDEDataManager.ResetToDefault(_key, animPathKey);
            GDEDataManager.ResetToDefault(_key, fsmPathKey);
            GDEDataManager.ResetToDefault(_key, healthPointKey);
            GDEDataManager.ResetToDefault(_key, speedBonusKey);
            GDEDataManager.ResetToDefault(_key, visionRangeKey);
            GDEDataManager.ResetToDefault(_key, atkRangeKey);
            GDEDataManager.ResetToDefault(_key, atkSpeedKey);
            GDEDataManager.ResetToDefault(_key, atkBonusKey);
            GDEDataManager.ResetToDefault(_key, defBonusKey);
            GDEDataManager.ResetToDefault(_key, dmgClampMinKey);
            GDEDataManager.ResetToDefault(_key, dmgClampMaxKey);
            GDEDataManager.ResetToDefault(_key, dmgCountKey);
            GDEDataManager.ResetToDefault(_key, weightRobRateKey);


            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            LoadFromDict(_key, dict);
        }
    }
}