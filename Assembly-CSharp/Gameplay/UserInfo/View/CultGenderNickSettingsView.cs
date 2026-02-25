using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Buttons;
using UI.Price;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F1 RID: 1009
	[Token(Token = "0x20003F1")]
	public class CultGenderNickSettingsView : MonoBehaviour
	{
		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000416")]
		public PatternTextInput NickInputField
		{
			[Token(Token = "0x60017A3")]
			[Address(RVA = "0x695E", Offset = "0x695E", VA = "0x695E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000417")]
		public Button ChangeNickButton
		{
			[Token(Token = "0x60017A4")]
			[Address(RVA = "0x695F", Offset = "0x695F", VA = "0x695F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000418")]
		public Button ChangeCultGenderButton
		{
			[Token(Token = "0x60017A5")]
			[Address(RVA = "0x6960", Offset = "0x6960", VA = "0x6960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000419")]
		public Button GenerateNickButton
		{
			[Token(Token = "0x60017A6")]
			[Address(RVA = "0x6961", Offset = "0x6961", VA = "0x6961")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041A")]
		public Price ChangeCultGenderPrice
		{
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x6962", Offset = "0x6962", VA = "0x6962")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041B")]
		public Price ChangeNickPrice
		{
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x6963", Offset = "0x6963", VA = "0x6963")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041C")]
		public Toggle HideMedalsCheckBox
		{
			[Token(Token = "0x60017A9")]
			[Address(RVA = "0x6964", Offset = "0x6964", VA = "0x6964")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041D")]
		public Toggle HideAprsCheckBox
		{
			[Token(Token = "0x60017AA")]
			[Address(RVA = "0x6965", Offset = "0x6965", VA = "0x6965")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041E")]
		public GameObject HideContentControls
		{
			[Token(Token = "0x60017AB")]
			[Address(RVA = "0x6966", Offset = "0x6966", VA = "0x6966")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041F")]
		public GameAssetViewRawImage Avatar
		{
			[Token(Token = "0x60017AC")]
			[Address(RVA = "0x6967", Offset = "0x6967", VA = "0x6967")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000114 RID: 276
		// (add) Token: 0x060017AD RID: 6061 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060017AE RID: 6062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000114")]
		public event Action OnGenderOrCultSelected
		{
			[Token(Token = "0x60017AD")]
			[Address(RVA = "0x6968", Offset = "0x6968", VA = "0x6968")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60017AE")]
			[Address(RVA = "0x6969", Offset = "0x6969", VA = "0x6969")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AF")]
		[Address(RVA = "0x696A", Offset = "0x696A", VA = "0x696A")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x696B", Offset = "0x696B", VA = "0x696B")]
		public void Start()
		{
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x696C", Offset = "0x696C", VA = "0x696C")]
		public void UpdateInfo()
		{
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x696D", Offset = "0x696D", VA = "0x696D")]
		private void HandleNickInputFieldStatusChanged(bool status)
		{
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x696E", Offset = "0x696E", VA = "0x696E")]
		private void CreateGenders()
		{
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x696F", Offset = "0x696F", VA = "0x696F")]
		private void CreateCults()
		{
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000420")]
		public GenderDic CurrentGender
		{
			[Token(Token = "0x60017B5")]
			[Address(RVA = "0x6970", Offset = "0x6970", VA = "0x6970")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017B6")]
			[Address(RVA = "0x6971", Offset = "0x6971", VA = "0x6971")]
			private set
			{
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000421")]
		public CultDic CurrentCult
		{
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x6972", Offset = "0x6972", VA = "0x6972")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017B8")]
			[Address(RVA = "0x6973", Offset = "0x6973", VA = "0x6973")]
			private set
			{
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x6974", Offset = "0x6974", VA = "0x6974")]
		private void HandleGenderToggleValueChangedEvent(bool selected)
		{
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x6975", Offset = "0x6975", VA = "0x6975")]
		private void HandleCultToggleValueChangedEvent(bool selected)
		{
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x6976", Offset = "0x6976", VA = "0x6976")]
		private void SetCultDescription(string text)
		{
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x6977", Offset = "0x6977", VA = "0x6977")]
		public CultGenderNickSettingsView()
		{
		}

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _gendersOwner;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _cultsOwner;

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _cultDescriptionField;

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _changeCultGenderButton;

		// Token: 0x04000C87 RID: 3207
		[Token(Token = "0x4000C87")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _changeNickButton;

		// Token: 0x04000C88 RID: 3208
		[Token(Token = "0x4000C88")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _generateNickButton;

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ToggleGroup _genderToggelGroup;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ToggleGroup _cultToggleGroup;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RadioButton _radioButtonPrefab;

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("_cultButtonPrefab")]
		[SerializeField]
		private CultRadioButton cultRadioButtonPrefab;

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Price _changeCultGenderPrice;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Price _changeNickPrice;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private PatternTextInput _nickInputField;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _nickInputStatusField;

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Toggle _hideMedalsCheckBox;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Toggle _hideAprsCheckBox;

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _hideContentControls;

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x5C")]
		public UserData User;

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x60")]
		public List<GenderDic> Genders;

		// Token: 0x04000C97 RID: 3223
		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x64")]
		public RepeatedField<CultDic> Cults;

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		public const string NICK_DOSNT_MATCH_THE_PATTERN_LOCALE_KEY = "NICK_DOSNT_MATCH_THE_PATTERN";

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x68")]
		private GenderDic _currentGender;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x6C")]
		private CultDic _currentCult;
	}
}
