using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B81 RID: 2945
	[Token(Token = "0x2000B81")]
	public class BossTeamEditListAdapter : OSA<BaseParamsWithPrefab, BossPossibleAssistantViewHolder>
	{
		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4D")]
		public SimpleDataHelper<UserData> Data
		{
			[Token(Token = "0x6004784")]
			[Address(RVA = "0x9614", Offset = "0x9614", VA = "0x9614")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004785")]
			[Address(RVA = "0x9615", Offset = "0x9615", VA = "0x9615")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001C4 RID: 452
		// (add) Token: 0x06004786 RID: 18310 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004787 RID: 18311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C4")]
		public event Action<UserData> ClickedEvent
		{
			[Token(Token = "0x6004786")]
			[Address(RVA = "0x9616", Offset = "0x9616", VA = "0x9616")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004787")]
			[Address(RVA = "0x9617", Offset = "0x9617", VA = "0x9617")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004788")]
		[Address(RVA = "0x9618", Offset = "0x9618", VA = "0x9618", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004789")]
		[Address(RVA = "0x9619", Offset = "0x9619", VA = "0x9619", Slot = "99")]
		protected override BossPossibleAssistantViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478A")]
		[Address(RVA = "0x961A", Offset = "0x961A", VA = "0x961A")]
		private void AssistantViewOnClickedEvent(UserData data)
		{
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478B")]
		[Address(RVA = "0x961B", Offset = "0x961B", VA = "0x961B", Slot = "100")]
		protected override void UpdateViewsHolder(BossPossibleAssistantViewHolder newOrRecycled)
		{
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478C")]
		[Address(RVA = "0x961C", Offset = "0x961C", VA = "0x961C", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossPossibleAssistantViewHolder vh, bool isActive)
		{
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478D")]
		[Address(RVA = "0x961D", Offset = "0x961D", VA = "0x961D")]
		public void AddItemsAt(int index, IList<UserData> items)
		{
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478E")]
		[Address(RVA = "0x961E", Offset = "0x961E", VA = "0x961E")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478F")]
		[Address(RVA = "0x961F", Offset = "0x961F", VA = "0x961F")]
		public void SetItems(IList<UserData> items)
		{
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004790")]
		[Address(RVA = "0x9620", Offset = "0x9620", VA = "0x9620")]
		public void Clear()
		{
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004791")]
		[Address(RVA = "0x9621", Offset = "0x9621", VA = "0x9621")]
		public BossTeamEditListAdapter()
		{
		}
	}
}
