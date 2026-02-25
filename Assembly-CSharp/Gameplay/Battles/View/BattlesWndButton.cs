using System;
using System.Runtime.CompilerServices;
using Gameplay.Battles.Model;
using Il2CppDummyDll;
using UI.Elements.Counters;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Battles.View
{
	// Token: 0x02000C2A RID: 3114
	[Token(Token = "0x2000C2A")]
	public class BattlesWndButton : MonoBehaviour
	{
		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06004BEC RID: 19436 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		[Token(Token = "0x17000F4C")]
		public ItemButtonTypes Type
		{
			[Token(Token = "0x6004BEC")]
			[Address(RVA = "0x9A30", Offset = "0x9A30", VA = "0x9A30")]
			get
			{
				return ItemButtonTypes.Unknown;
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F4D")]
		public CounterAutoHide Counter
		{
			[Token(Token = "0x6004BED")]
			[Address(RVA = "0x9A31", Offset = "0x9A31", VA = "0x9A31")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001D8 RID: 472
		// (add) Token: 0x06004BEE RID: 19438 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004BEF RID: 19439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D8")]
		public event Action<BattlesWndButton> OnClick
		{
			[Token(Token = "0x6004BEE")]
			[Address(RVA = "0x9A32", Offset = "0x9A32", VA = "0x9A32")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004BEF")]
			[Address(RVA = "0x9A33", Offset = "0x9A33", VA = "0x9A33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F4E")]
		public Price Price
		{
			[Token(Token = "0x6004BF0")]
			[Address(RVA = "0x9A34", Offset = "0x9A34", VA = "0x9A34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x17000F4F")]
		public uint UIElementId
		{
			[Token(Token = "0x6004BF1")]
			[Address(RVA = "0x9A35", Offset = "0x9A35", VA = "0x9A35")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (set) Token: 0x06004BF2 RID: 19442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F50")]
		public bool ShowPrice
		{
			[Token(Token = "0x6004BF2")]
			[Address(RVA = "0x9A36", Offset = "0x9A36", VA = "0x9A36")]
			set
			{
			}
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF3")]
		[Address(RVA = "0x9A37", Offset = "0x9A37", VA = "0x9A37")]
		public void SetLockEnabled(bool value)
		{
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF4")]
		[Address(RVA = "0x9A38", Offset = "0x9A38", VA = "0x9A38")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF5")]
		[Address(RVA = "0x9A39", Offset = "0x9A39", VA = "0x9A39")]
		private void Awake()
		{
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0x9A3A", Offset = "0x9A3A", VA = "0x9A3A")]
		private void OnClickButton()
		{
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BF7")]
		[Address(RVA = "0x9A3B", Offset = "0x9A3B", VA = "0x9A3B")]
		public BattlesWndButton()
		{
		}

		// Token: 0x0400295B RID: 10587
		[Token(Token = "0x400295B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private uint _uiElementId;

		// Token: 0x0400295C RID: 10588
		[Token(Token = "0x400295C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400295D RID: 10589
		[Token(Token = "0x400295D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x0400295E RID: 10590
		[Token(Token = "0x400295E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x0400295F RID: 10591
		[Token(Token = "0x400295F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemButtonTypes _type;

		// Token: 0x04002960 RID: 10592
		[Token(Token = "0x4002960")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _lockImage;
	}
}
