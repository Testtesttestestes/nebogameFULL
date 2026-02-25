using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexCombat.View.Player
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	public class VortexCombatProgressBar : CombatProgressBar
	{
		// Token: 0x06001613 RID: 5651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x67D4", Offset = "0x67D4", VA = "0x67D4")]
		private void HandleStoneTypeChanged()
		{
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x67D5", Offset = "0x67D5", VA = "0x67D5")]
		private void SetBarSprite(Image[] bars, Sprite sprite)
		{
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00005358 File Offset: 0x00003558
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A8")]
		public StonesTypes StoneType
		{
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x67D6", Offset = "0x67D6", VA = "0x67D6")]
			get
			{
				return StonesTypes.Empty;
			}
			[Token(Token = "0x6001616")]
			[Address(RVA = "0x67D7", Offset = "0x67D7", VA = "0x67D7")]
			set
			{
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x67D8", Offset = "0x67D8", VA = "0x67D8")]
		public void SetIcon(Sprite sprite)
		{
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x67D9", Offset = "0x67D9", VA = "0x67D9")]
		public VortexCombatProgressBar()
		{
		}

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image[] _topBars;

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image[] _bottomBars;

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public VortexCombatProgressBar.Config[] Settings;

		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x40")]
		private StonesTypes _stoneType;

		// Token: 0x020003AF RID: 943
		[Token(Token = "0x20003AF")]
		[Serializable]
		public class Config
		{
			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x0600161A RID: 5658 RVA: 0x00005388 File Offset: 0x00003588
			[Token(Token = "0x170003A9")]
			public StonesTypes Stone
			{
				[Token(Token = "0x600161A")]
				[Address(RVA = "0x67DB", Offset = "0x67DB", VA = "0x67DB")]
				get
				{
					return StonesTypes.Empty;
				}
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x0600161B RID: 5659 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003AA")]
			public Sprite Icon
			{
				[Token(Token = "0x600161B")]
				[Address(RVA = "0x67DC", Offset = "0x67DC", VA = "0x67DC")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x0600161C RID: 5660 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003AB")]
			public Sprite TopProgressBar
			{
				[Token(Token = "0x600161C")]
				[Address(RVA = "0x67DD", Offset = "0x67DD", VA = "0x67DD")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x0600161D RID: 5661 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003AC")]
			public Sprite BottomProgressBar
			{
				[Token(Token = "0x600161D")]
				[Address(RVA = "0x67DE", Offset = "0x67DE", VA = "0x67DE")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600161E RID: 5662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600161E")]
			[Address(RVA = "0x67DF", Offset = "0x67DF", VA = "0x67DF")]
			public Config()
			{
			}

			// Token: 0x04000BB6 RID: 2998
			[Token(Token = "0x4000BB6")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private StonesTypes _stone;

			// Token: 0x04000BB7 RID: 2999
			[Token(Token = "0x4000BB7")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Sprite _icon;

			// Token: 0x04000BB8 RID: 3000
			[Token(Token = "0x4000BB8")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Sprite _topProgressBar;

			// Token: 0x04000BB9 RID: 3001
			[Token(Token = "0x4000BB9")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Sprite _bottomProgressBar;
		}
	}
}
