using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.VortexRating.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View.GreatOnesTab
{
	// Token: 0x02000392 RID: 914
	[Token(Token = "0x2000392")]
	public class GreatUserView : MonoBehaviour
	{
		// Token: 0x1400010F RID: 271
		// (add) Token: 0x06001545 RID: 5445 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001546 RID: 5446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010F")]
		public event Action<GreatUserView> LikeButtonClickedEvent
		{
			[Token(Token = "0x6001545")]
			[Address(RVA = "0x6707", Offset = "0x6707", VA = "0x6707")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001546")]
			[Address(RVA = "0x6708", Offset = "0x6708", VA = "0x6708")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000381")]
		public GreatUserData UserData
		{
			[Token(Token = "0x6001547")]
			[Address(RVA = "0x6709", Offset = "0x6709", VA = "0x6709")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001548")]
			[Address(RVA = "0x670A", Offset = "0x670A", VA = "0x670A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000382")]
		public Button LikeButton
		{
			[Token(Token = "0x6001549")]
			[Address(RVA = "0x670B", Offset = "0x670B", VA = "0x670B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000383")]
		public TextMeshProUGUI VortexRating
		{
			[Token(Token = "0x600154A")]
			[Address(RVA = "0x670C", Offset = "0x670C", VA = "0x670C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000384")]
		public TextMeshProUGUI LikesRating
		{
			[Token(Token = "0x600154B")]
			[Address(RVA = "0x670D", Offset = "0x670D", VA = "0x670D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000385")]
		public GameAssetViewRawImage AvatarView
		{
			[Token(Token = "0x600154C")]
			[Address(RVA = "0x670E", Offset = "0x670E", VA = "0x670E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000386")]
		public RewardsRender RewardsView
		{
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x670F", Offset = "0x670F", VA = "0x670F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000387")]
		public LevelCounter Level
		{
			[Token(Token = "0x600154E")]
			[Address(RVA = "0x6710", Offset = "0x6710", VA = "0x6710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000388")]
		public TextMeshProUGUI Nickname
		{
			[Token(Token = "0x600154F")]
			[Address(RVA = "0x6711", Offset = "0x6711", VA = "0x6711")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001550")]
		[Address(RVA = "0x6712", Offset = "0x6712", VA = "0x6712")]
		private void Awake()
		{
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001551")]
		[Address(RVA = "0x6713", Offset = "0x6713", VA = "0x6713")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001552")]
		[Address(RVA = "0x6714", Offset = "0x6714", VA = "0x6714")]
		public void Init(GreatUserData data)
		{
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001553")]
		[Address(RVA = "0x6715", Offset = "0x6715", VA = "0x6715")]
		private void LikeButtonClickedEventHandler()
		{
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x6716", Offset = "0x6716", VA = "0x6716")]
		public GreatUserView()
		{
		}

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _likeButton;

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4000B50")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _vortexRating;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _likesRating;

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameAssetViewRawImage _avatarView;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LevelCounter _level;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _nickname;
	}
}
