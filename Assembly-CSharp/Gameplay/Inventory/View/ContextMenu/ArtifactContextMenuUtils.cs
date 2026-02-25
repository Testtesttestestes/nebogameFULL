using System;
using System.Collections.Generic;
using Gameplay.Inventory.ContextMenu;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.View.ContextMenu
{
	// Token: 0x02000680 RID: 1664
	[Token(Token = "0x2000680")]
	public static class ArtifactContextMenuUtils
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A4")]
		public static ArtikulMenuActionDic.Types.Actions[] DefaultActions
		{
			[Token(Token = "0x600284F")]
			[Address(RVA = "0x796F", Offset = "0x796F", VA = "0x796F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002850")]
		[Address(RVA = "0x7970", Offset = "0x7970", VA = "0x7970")]
		public static List<AbstractArtifactContextMenuElement> GetElements(ArtikulMenuActionDic.Types.Actions[] customActions)
		{
			return null;
		}

		// Token: 0x0400163B RID: 5691
		[Token(Token = "0x400163B")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<ArtikulMenuActionDic.Types.Actions> _excludeFromDefaultElements;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[FieldOffset(Offset = "0x4")]
		private static AbstractArtifactContextMenuElement[] _allElements;

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[FieldOffset(Offset = "0x8")]
		private static ArtikulMenuActionDic.Types.Actions[] _defaultActions;
	}
}
