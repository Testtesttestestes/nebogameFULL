using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ContextMenu
{
	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000251")]
	[Serializable]
	public struct ContextMenuConfigurationItem
	{
		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x0")]
		public ContextMenuId Id;

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0x4")]
		public GameObject ContextMenuPrefab;
	}
}
