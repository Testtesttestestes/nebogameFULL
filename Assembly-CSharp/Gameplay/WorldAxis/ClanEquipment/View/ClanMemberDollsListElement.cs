using System;
using Gameplay.WorldAxis.ClanEquipment.Model;
using Gameplay.WorldAxis.Office.View.Ratings;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.WorldAxis.ClanEquipment.View
{
	// Token: 0x02000344 RID: 836
	[Token(Token = "0x2000344")]
	public class ClanMemberDollsListElement : SelectableListElement<ClanMemberDollsListElement.ClanMemberDollsListElementArgs>
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x652E", Offset = "0x652E", VA = "0x652E", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x652F", Offset = "0x652F", VA = "0x652F", Slot = "10")]
		protected override void CallElementClickedEvent(ClanMemberDollsListElement.ClanMemberDollsListElementArgs args)
		{
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x6530", Offset = "0x6530", VA = "0x6530")]
		public ClanMemberDollsListElement()
		{
		}

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UserBasicViewElements _basicElements;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LevelCounter _level;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _itemsCountText;

		// Token: 0x02000345 RID: 837
		[Token(Token = "0x2000345")]
		public class ClanMemberDollsListElementArgs : SelectableListElementArgs<ClanMemberDollsListElement>
		{
			// Token: 0x17000306 RID: 774
			// (get) Token: 0x06001340 RID: 4928 RVA: 0x00004AD0 File Offset: 0x00002CD0
			[Token(Token = "0x17000306")]
			public int ItemsCount
			{
				[Token(Token = "0x6001340")]
				[Address(RVA = "0x6531", Offset = "0x6531", VA = "0x6531")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06001341 RID: 4929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001341")]
			[Address(RVA = "0x6532", Offset = "0x6532", VA = "0x6532")]
			public ClanMemberDollsListElementArgs()
			{
			}

			// Token: 0x04000A50 RID: 2640
			[Token(Token = "0x4000A50")]
			[FieldOffset(Offset = "0x1C")]
			public ClanEquipmentModel.DollsOwner DollsOwner;
		}
	}
}
