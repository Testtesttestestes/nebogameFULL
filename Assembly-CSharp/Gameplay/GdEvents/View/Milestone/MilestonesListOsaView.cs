using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace Gameplay.GdEvents.View.Milestone
{
	// Token: 0x02000721 RID: 1825
	[Token(Token = "0x2000721")]
	public class MilestonesListOsaView : OSA<BaseParamsWithPrefab, MyItemViewsHolder>
	{
		// Token: 0x1400015F RID: 351
		// (add) Token: 0x06002BAA RID: 11178 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002BAB RID: 11179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015F")]
		public event Action<MilestoneData> ClickEvent
		{
			[Token(Token = "0x6002BAA")]
			[Address(RVA = "0x7C41", Offset = "0x7C41", VA = "0x7C41")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002BAB")]
			[Address(RVA = "0x7C42", Offset = "0x7C42", VA = "0x7C42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000852")]
		public SimpleDataHelper<MilestoneData> Data
		{
			[Token(Token = "0x6002BAC")]
			[Address(RVA = "0x7C43", Offset = "0x7C43", VA = "0x7C43")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BAD")]
			[Address(RVA = "0x7C44", Offset = "0x7C44", VA = "0x7C44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0x7C45", Offset = "0x7C45", VA = "0x7C45", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x7C46", Offset = "0x7C46", VA = "0x7C46", Slot = "99")]
		protected override MyItemViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB0")]
		[Address(RVA = "0x7C47", Offset = "0x7C47", VA = "0x7C47", Slot = "100")]
		protected override void UpdateViewsHolder(MyItemViewsHolder newOrRecycled)
		{
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB1")]
		[Address(RVA = "0x7C48", Offset = "0x7C48", VA = "0x7C48", Slot = "101")]
		protected override void OnItemIndexChangedDueInsertOrRemove(MyItemViewsHolder shiftedViewsHolder, int oldIndex, bool wasInsert, int removeOrInsertIndex)
		{
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB2")]
		[Address(RVA = "0x7C49", Offset = "0x7C49", VA = "0x7C49", Slot = "83")]
		public override void ChangeItemsCount(ItemCountChangeMode changeMode, int itemsCount, int indexIfInsertingOrRemoving = -1, bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB3")]
		[Address(RVA = "0x7C4A", Offset = "0x7C4A", VA = "0x7C4A")]
		private void DispatchClickEvent(MilestoneData data)
		{
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB4")]
		[Address(RVA = "0x7C4B", Offset = "0x7C4B", VA = "0x7C4B")]
		public MilestonesListOsaView()
		{
		}

		// Token: 0x040017EC RID: 6124
		[Token(Token = "0x40017EC")]
		[FieldOffset(Offset = "0xA4")]
		public UnityEvent OnItemsUpdated;
	}
}
