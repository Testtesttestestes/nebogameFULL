using System;
using AssetContent;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using UI.Elements.RightPanel;
using UI.Elements.RightPanel.TitledList;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Monsters
{
	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	public class MonsterInfoWindow : ClosableBaseWindow<MonsterInfoWindow.MonsterInfoWindowArgs>
	{
		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000856")]
		public override string WindowId
		{
			[Token(Token = "0x6002BC2")]
			[Address(RVA = "0x7C53", Offset = "0x7C53", VA = "0x7C53", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x7C54", Offset = "0x7C54", VA = "0x7C54", Slot = "22")]
		protected override void OnShow(MonsterInfoWindow.MonsterInfoWindowArgs args)
		{
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x7C55", Offset = "0x7C55", VA = "0x7C55")]
		public MonsterInfoWindow()
		{
		}

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GdEvents/MonsterInfoWindow";

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TitleWithLevel _windowTitle;

		// Token: 0x040017F4 RID: 6132
		[Token(Token = "0x40017F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameAssetViewRawImage _monsterAssetView;

		// Token: 0x040017F5 RID: 6133
		[Token(Token = "0x40017F5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TitledList _titledList;

		// Token: 0x040017F6 RID: 6134
		[Token(Token = "0x40017F6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _background;

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Transform _bossBackground;

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _pedestal;

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Transform _bossPedestal;

		// Token: 0x02000726 RID: 1830
		[Token(Token = "0x2000726")]
		public class MonsterInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002BC5 RID: 11205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002BC5")]
			[Address(RVA = "0x7C56", Offset = "0x7C56", VA = "0x7C56")]
			public MonsterInfoWindowArgs(IDictProvider dictProvider, MonsterData monster)
			{
			}

			// Token: 0x040017FA RID: 6138
			[Token(Token = "0x40017FA")]
			[FieldOffset(Offset = "0x18")]
			public readonly MonsterData Monster;

			// Token: 0x040017FB RID: 6139
			[Token(Token = "0x40017FB")]
			[FieldOffset(Offset = "0x1C")]
			public readonly IDictProvider DictProvider;
		}
	}
}
