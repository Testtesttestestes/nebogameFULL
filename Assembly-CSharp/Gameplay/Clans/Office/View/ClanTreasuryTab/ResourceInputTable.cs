using System;
using System.Collections.Generic;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using Scripts.UI.Filters;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanTreasuryTab
{
	// Token: 0x02000A0C RID: 2572
	[Token(Token = "0x2000A0C")]
	public class ResourceInputTable : MonoBehaviour
	{
		// Token: 0x06003D1E RID: 15646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1E")]
		[Address(RVA = "0x8BDE", Offset = "0x8BDE", VA = "0x8BDE")]
		public void Init(Dictionaries dict)
		{
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1F")]
		[Address(RVA = "0x8BDF", Offset = "0x8BDF", VA = "0x8BDF")]
		public void Init(Dictionaries dict, ResourceSet maxLimits)
		{
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D20")]
		[Address(RVA = "0x8BE0", Offset = "0x8BE0", VA = "0x8BE0")]
		public ResourceSet GetInputResources()
		{
			return null;
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D21")]
		[Address(RVA = "0x8BE1", Offset = "0x8BE1", VA = "0x8BE1")]
		public void UpdateBounds(Money lowerBound, Money upperBound)
		{
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D22")]
		[Address(RVA = "0x8BE2", Offset = "0x8BE2", VA = "0x8BE2")]
		public void UpdateUpperBound(Money resourceSet)
		{
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D23")]
		[Address(RVA = "0x8BE3", Offset = "0x8BE3", VA = "0x8BE3")]
		public void UpdateLowerBound(Money resourceSet)
		{
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D24")]
		[Address(RVA = "0x8BE4", Offset = "0x8BE4", VA = "0x8BE4")]
		public void PopulateResources(Money money)
		{
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D25")]
		[Address(RVA = "0x8BE5", Offset = "0x8BE5", VA = "0x8BE5")]
		public ResourceInputTable()
		{
		}

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceInputTable.ResourceInput[] _inputs;

		// Token: 0x040021F4 RID: 8692
		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<Protocol.Consts.Resources, ClampedNumberInput> _inputsByResourceId;

		// Token: 0x02000A0D RID: 2573
		[Token(Token = "0x2000A0D")]
		[Serializable]
		public struct ResourceInput
		{
			// Token: 0x040021F5 RID: 8693
			[Token(Token = "0x40021F5")]
			[FieldOffset(Offset = "0x0")]
			public Protocol.Consts.Resources ResourceId;

			// Token: 0x040021F6 RID: 8694
			[Token(Token = "0x40021F6")]
			[FieldOffset(Offset = "0x4")]
			public ClampedNumberInput Input;
		}
	}
}
