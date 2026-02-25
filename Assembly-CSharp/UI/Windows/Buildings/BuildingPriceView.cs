using System;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	public class BuildingPriceView : MonoBehaviour
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024D")]
		public ResourceSet Price
		{
			[Token(Token = "0x6001020")]
			[Address(RVA = "0x622A", Offset = "0x622A", VA = "0x622A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001021")]
			[Address(RVA = "0x622B", Offset = "0x622B", VA = "0x622B")]
			set
			{
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x622C", Offset = "0x622C", VA = "0x622C")]
		public BuildingPriceView()
		{
		}

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BuildingPriceItemView _priceItemPrefab;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x18")]
		private ResourceSet _price;
	}
}
