using System;
using AssetContent;
using Gameplay.UserInfo.View.Equipment;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	public class UserInfoView : MonoBehaviourWithStates<UserInfoView.State>
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000435")]
		public UserNickCultLevelExpView UserNickBar
		{
			[Token(Token = "0x6001820")]
			[Address(RVA = "0x69D4", Offset = "0x69D4", VA = "0x69D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000436")]
		public UserEquipmentView EquipmentView
		{
			[Token(Token = "0x6001821")]
			[Address(RVA = "0x69D5", Offset = "0x69D5", VA = "0x69D5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000437")]
		public GameAssetViewRawImage Avatar
		{
			[Token(Token = "0x6001822")]
			[Address(RVA = "0x69D6", Offset = "0x69D6", VA = "0x69D6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000438")]
		public Transform EquipmentStub
		{
			[Token(Token = "0x6001823")]
			[Address(RVA = "0x69D7", Offset = "0x69D7", VA = "0x69D7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000439")]
		public IndexButtonBasic UserAprsButton
		{
			[Token(Token = "0x6001824")]
			[Address(RVA = "0x69D8", Offset = "0x69D8", VA = "0x69D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700043A")]
		public IndexButtonBasic MedalButton
		{
			[Token(Token = "0x6001825")]
			[Address(RVA = "0x69D9", Offset = "0x69D9", VA = "0x69D9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700043B")]
		public IndexButtonBasic CollectionsButton
		{
			[Token(Token = "0x6001826")]
			[Address(RVA = "0x69DA", Offset = "0x69DA", VA = "0x69DA")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700043C")]
		public IndexButtonBasic AntiqButton
		{
			[Token(Token = "0x6001827")]
			[Address(RVA = "0x69DB", Offset = "0x69DB", VA = "0x69DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700043D")]
		public Button EditButton
		{
			[Token(Token = "0x6001828")]
			[Address(RVA = "0x69DC", Offset = "0x69DC", VA = "0x69DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700043E")]
		public Button InfoButton
		{
			[Token(Token = "0x6001829")]
			[Address(RVA = "0x69DD", Offset = "0x69DD", VA = "0x69DD")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700043F")]
		public Button RatingButton
		{
			[Token(Token = "0x600182A")]
			[Address(RVA = "0x69DE", Offset = "0x69DE", VA = "0x69DE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000440")]
		public Button DuelButton
		{
			[Token(Token = "0x600182B")]
			[Address(RVA = "0x69DF", Offset = "0x69DF", VA = "0x69DF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000441")]
		public SelectedButton AddOrRemoveFromChatFavoritesButton
		{
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x69E0", Offset = "0x69E0", VA = "0x69E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000442")]
		public Button ChatBanButton
		{
			[Token(Token = "0x600182D")]
			[Address(RVA = "0x69E1", Offset = "0x69E1", VA = "0x69E1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000443")]
		public SkillsInfoView UserSkillsInfoBox
		{
			[Token(Token = "0x600182E")]
			[Address(RVA = "0x69E2", Offset = "0x69E2", VA = "0x69E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000444")]
		public UserRatingView UserRatingInfoBox
		{
			[Token(Token = "0x600182F")]
			[Address(RVA = "0x69E3", Offset = "0x69E3", VA = "0x69E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000445")]
		public MarkersView MarkersView
		{
			[Token(Token = "0x6001830")]
			[Address(RVA = "0x69E4", Offset = "0x69E4", VA = "0x69E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000446")]
		public BaseInfoBox[] AllInfoBoxes
		{
			[Token(Token = "0x6001831")]
			[Address(RVA = "0x69E5", Offset = "0x69E5", VA = "0x69E5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000447")]
		public Transform GuestMenu
		{
			[Token(Token = "0x6001832")]
			[Address(RVA = "0x69E6", Offset = "0x69E6", VA = "0x69E6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001833")]
		[Address(RVA = "0x69E7", Offset = "0x69E7", VA = "0x69E7")]
		public UserInfoView()
		{
		}

		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000CD5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000CD6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UserEquipmentView _equipmentView;

		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000CD7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private IndexButtonBasic _userAprsButton;

		// Token: 0x04000CD8 RID: 3288
		[Token(Token = "0x4000CD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IndexButtonBasic _medalButton;

		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private IndexButtonBasic _collectionsButton;

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private IndexButtonBasic _antiqButton;

		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _editButton;

		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _ratingButton;

		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _duelButton;

		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SelectedButton _addOrRemoveFromChatFavoritesButton;

		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _equipmentStub;

		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Transform _guestMenu;

		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SkillsInfoView _skillsInfoBox;

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private UserRatingView _ratingInfoBox;

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MarkersView _markersView;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private BaseInfoBox[] _allInfoBoxes;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _chatBanButton;

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private UserNickCultLevelExpView _userNickBar;

		// Token: 0x02000404 RID: 1028
		[Token(Token = "0x2000404")]
		public enum State
		{
			// Token: 0x04000CE9 RID: 3305
			[Token(Token = "0x4000CE9")]
			UNKNOWN,
			// Token: 0x04000CEA RID: 3306
			[Token(Token = "0x4000CEA")]
			DEFAULT,
			// Token: 0x04000CEB RID: 3307
			[Token(Token = "0x4000CEB")]
			GUEST
		}
	}
}
