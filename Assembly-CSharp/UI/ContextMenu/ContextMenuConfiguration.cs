using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ContextMenu
{
	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	[CreateAssetMenu(menuName = "Heavens/ContextMenu/Create ContextMenu configuration")]
	public class ContextMenuConfiguration : ScriptableObject
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x60E8", Offset = "0x60E8", VA = "0x60E8")]
		public ContextMenuConfigurationItem GetConfig(ContextMenuId menuId)
		{
			return default(ContextMenuConfigurationItem);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x60E9", Offset = "0x60E9", VA = "0x60E9")]
		public ContextMenuConfiguration()
		{
		}

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0xC")]
		public ContextMenuConfigurationItem[] Items;
	}
}
