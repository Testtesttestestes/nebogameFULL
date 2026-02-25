using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data.Balance;
using Core.Materials;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.SquadTab
{
	// Token: 0x02000A0E RID: 2574
	[Token(Token = "0x2000A0E")]
	public class MemberSlotView : MonoBehaviourWithStates<MemberSlotView.State>, IGrayscalable
	{
		// Token: 0x14000191 RID: 401
		// (add) Token: 0x06003D26 RID: 15654 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D27 RID: 15655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000191")]
		public event Action<MemberSlotView> JoinButtonClickedEvent
		{
			[Token(Token = "0x6003D26")]
			[Address(RVA = "0x8BE6", Offset = "0x8BE6", VA = "0x8BE6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D27")]
			[Address(RVA = "0x8BE7", Offset = "0x8BE7", VA = "0x8BE7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000192 RID: 402
		// (add) Token: 0x06003D28 RID: 15656 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D29 RID: 15657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000192")]
		public event Action<MemberSlotView> CrossButtonClickedEvent
		{
			[Token(Token = "0x6003D28")]
			[Address(RVA = "0x8BE8", Offset = "0x8BE8", VA = "0x8BE8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D29")]
			[Address(RVA = "0x8BE9", Offset = "0x8BE9", VA = "0x8BE9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06003D2A RID: 15658 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D2B RID: 15659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C19")]
		public SquadModel.ColossusPartySlot PartySlot
		{
			[Token(Token = "0x6003D2A")]
			[Address(RVA = "0x8BEA", Offset = "0x8BEA", VA = "0x8BEA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D2B")]
			[Address(RVA = "0x8BEB", Offset = "0x8BEB", VA = "0x8BEB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x17000C1A")]
		public bool IsActive
		{
			[Token(Token = "0x6003D2C")]
			[Address(RVA = "0x8BEC", Offset = "0x8BEC", VA = "0x8BEC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2D")]
		[Address(RVA = "0x8BED", Offset = "0x8BED", VA = "0x8BED")]
		private void Awake()
		{
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2E")]
		[Address(RVA = "0x8BEE", Offset = "0x8BEE", VA = "0x8BEE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2F")]
		[Address(RVA = "0x8BEF", Offset = "0x8BEF", VA = "0x8BEF")]
		public void Init(ColossusSlotsInfoDic dic, IBalanceSource treasury)
		{
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D30")]
		[Address(RVA = "0x8BF0", Offset = "0x8BF0", VA = "0x8BF0")]
		public void UpdateData(SquadModel.ColossusPartySlot slot)
		{
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D31")]
		[Address(RVA = "0x8BF1", Offset = "0x8BF1", VA = "0x8BF1")]
		private void JoinButtonClickedEventHandler()
		{
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D32")]
		[Address(RVA = "0x8BF2", Offset = "0x8BF2", VA = "0x8BF2")]
		private void CrossButtonClickedEventHandler()
		{
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D33")]
		[Address(RVA = "0x8BF3", Offset = "0x8BF3", VA = "0x8BF3", Slot = "5")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D34")]
		[Address(RVA = "0x8BF4", Offset = "0x8BF4", VA = "0x8BF4")]
		public MemberSlotView()
		{
		}

		// Token: 0x040021F7 RID: 8695
		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ImageWithGrayscale _placeHolderImage;

		// Token: 0x040021F8 RID: 8696
		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ImageWithGrayscale _borderImage;

		// Token: 0x040021F9 RID: 8697
		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _selector;

		// Token: 0x040021FA RID: 8698
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _lockSprite;

		// Token: 0x040021FB RID: 8699
		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _plusSprite;

		// Token: 0x040021FC RID: 8700
		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _joinButton;

		// Token: 0x040021FD RID: 8701
		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _crossButton;

		// Token: 0x040021FE RID: 8702
		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameAssetViewRawImage _dollImage;

		// Token: 0x040021FF RID: 8703
		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Price _price;

		// Token: 0x02000A0F RID: 2575
		[Token(Token = "0x2000A0F")]
		public enum State
		{
			// Token: 0x04002204 RID: 8708
			[Token(Token = "0x4002204")]
			UNKNOWN_STATE,
			// Token: 0x04002205 RID: 8709
			[Token(Token = "0x4002205")]
			EMPTY,
			// Token: 0x04002206 RID: 8710
			[Token(Token = "0x4002206")]
			LOCKED,
			// Token: 0x04002207 RID: 8711
			[Token(Token = "0x4002207")]
			INACTIVE,
			// Token: 0x04002208 RID: 8712
			[Token(Token = "0x4002208")]
			FILLED
		}
	}
}
