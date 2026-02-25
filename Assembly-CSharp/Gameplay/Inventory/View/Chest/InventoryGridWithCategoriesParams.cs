using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x0200068C RID: 1676
	[Token(Token = "0x200068C")]
	[Serializable]
	public class InventoryGridWithCategoriesParams : GridParams
	{
		// Token: 0x06002884 RID: 10372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002884")]
		[Address(RVA = "0x79A4", Offset = "0x79A4", VA = "0x79A4", Slot = "9")]
		protected override GameObject CreateCellGroupPrefabGameObject()
		{
			return null;
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002885")]
		[Address(RVA = "0x79A5", Offset = "0x79A5", VA = "0x79A5")]
		public InventoryGridWithCategoriesParams()
		{
		}

		// Token: 0x0400165B RID: 5723
		[Token(Token = "0x400165B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _cellGroupPrefab;
	}
}
