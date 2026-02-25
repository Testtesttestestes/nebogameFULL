using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Buildings.MagicTower.Controller;
using Gameplay.Clans.Buildings.MagicTower.Events;
using Gameplay.Clans.Buildings.MagicTower.Model;
using Gameplay.Isles.Clan;
using Gameplay.School.Model;
using Gameplay.School.View;
using Il2CppDummyDll;
using UI.Windows.Buildings;
using UnityEngine;

namespace Gameplay.Clans.Buildings.MagicTower.View
{
	// Token: 0x02000AB3 RID: 2739
	[Token(Token = "0x2000AB3")]
	public class MagicTowerWindow : BaseClanBuildingWindow<MagicTowerWindow.MagicTowerWindowArgs>
	{
		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06004212 RID: 16914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D04")]
		public override string WindowId
		{
			[Token(Token = "0x6004212")]
			[Address(RVA = "0x90C6", Offset = "0x90C6", VA = "0x90C6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D05")]
		public TitledListWithSpellTitle List
		{
			[Token(Token = "0x6004213")]
			[Address(RVA = "0x90C7", Offset = "0x90C7", VA = "0x90C7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004215 RID: 16917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D06")]
		public ClanSpellListElement[] Spells
		{
			[Token(Token = "0x6004214")]
			[Address(RVA = "0x90C8", Offset = "0x90C8", VA = "0x90C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004215")]
			[Address(RVA = "0x90C9", Offset = "0x90C9", VA = "0x90C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400019F RID: 415
		// (add) Token: 0x06004216 RID: 16918 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004217 RID: 16919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019F")]
		public event Action<SchoolSpellData> SelectSpellEvent
		{
			[Token(Token = "0x6004216")]
			[Address(RVA = "0x90CA", Offset = "0x90CA", VA = "0x90CA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004217")]
			[Address(RVA = "0x90CB", Offset = "0x90CB", VA = "0x90CB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001A0 RID: 416
		// (add) Token: 0x06004218 RID: 16920 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004219 RID: 16921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A0")]
		public event Action DeselectSpellEvent
		{
			[Token(Token = "0x6004218")]
			[Address(RVA = "0x90CC", Offset = "0x90CC", VA = "0x90CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004219")]
			[Address(RVA = "0x90CD", Offset = "0x90CD", VA = "0x90CD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001A1 RID: 417
		// (add) Token: 0x0600421A RID: 16922 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600421B RID: 16923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A1")]
		public event Action<SchoolSpellData> UseSpellButtonClickedEvent
		{
			[Token(Token = "0x600421A")]
			[Address(RVA = "0x90CE", Offset = "0x90CE", VA = "0x90CE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600421B")]
			[Address(RVA = "0x90CF", Offset = "0x90CF", VA = "0x90CF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421C")]
		[Address(RVA = "0x90D0", Offset = "0x90D0", VA = "0x90D0", Slot = "22")]
		protected override void OnShow(MagicTowerWindow.MagicTowerWindowArgs args)
		{
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421D")]
		[Address(RVA = "0x90D1", Offset = "0x90D1", VA = "0x90D1", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421E")]
		[Address(RVA = "0x90D2", Offset = "0x90D2", VA = "0x90D2")]
		public void Init(IList<SchoolSpellData> spells)
		{
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421F")]
		[Address(RVA = "0x90D3", Offset = "0x90D3", VA = "0x90D3")]
		private void UseButtonClickedEventHandler(ClanSpellListElement element)
		{
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004220")]
		[Address(RVA = "0x90D4", Offset = "0x90D4", VA = "0x90D4")]
		private void SelectEventHandler(ClanSpellListElement element)
		{
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x90D5", Offset = "0x90D5", VA = "0x90D5")]
		private void SetupMVC()
		{
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004222")]
		[Address(RVA = "0x90D6", Offset = "0x90D6", VA = "0x90D6")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004223")]
		[Address(RVA = "0x90D7", Offset = "0x90D7", VA = "0x90D7")]
		public MagicTowerWindow()
		{
		}

		// Token: 0x04002478 RID: 9336
		[Token(Token = "0x4002478")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Buildings/MagicTowerWindow";

		// Token: 0x04002479 RID: 9337
		[Token(Token = "0x4002479")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TitledListWithSpellTitle _titledList;

		// Token: 0x0400247A RID: 9338
		[Token(Token = "0x400247A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400247B RID: 9339
		[Token(Token = "0x400247B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClanSpellListElement _listElementPrefab;

		// Token: 0x04002480 RID: 9344
		[Token(Token = "0x4002480")]
		[FieldOffset(Offset = "0x5C")]
		private ClanSpellListElement _selectedElement;

		// Token: 0x04002481 RID: 9345
		[Token(Token = "0x4002481")]
		[FieldOffset(Offset = "0x60")]
		private MagicTowerModel _model;

		// Token: 0x04002482 RID: 9346
		[Token(Token = "0x4002482")]
		[FieldOffset(Offset = "0x64")]
		private MagicTowerEvents _events;

		// Token: 0x04002483 RID: 9347
		[Token(Token = "0x4002483")]
		[FieldOffset(Offset = "0x68")]
		private MagicTowerController _controller;

		// Token: 0x04002484 RID: 9348
		[Token(Token = "0x4002484")]
		[FieldOffset(Offset = "0x6C")]
		private MagicTowerViewMediator _mediator;

		// Token: 0x04002485 RID: 9349
		[Token(Token = "0x4002485")]
		[FieldOffset(Offset = "0x70")]
		private bool _mvcSetup;

		// Token: 0x02000AB4 RID: 2740
		[Token(Token = "0x2000AB4")]
		public class MagicTowerWindowArgs : BaseClanBuildingWindowArgs
		{
			// Token: 0x06004224 RID: 16932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004224")]
			[Address(RVA = "0x90D8", Offset = "0x90D8", VA = "0x90D8")]
			public MagicTowerWindowArgs(ClanIsle isle, uint buildingTypeId)
			{
			}
		}
	}
}
