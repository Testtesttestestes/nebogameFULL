using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000694 RID: 1684
	[Token(Token = "0x2000694")]
	[Serializable]
	public class MedalsGridWithCategoriesParams : GridParams
	{
		// Token: 0x060028B4 RID: 10420 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x79D3", Offset = "0x79D3", VA = "0x79D3", Slot = "9")]
		protected override GameObject CreateCellGroupPrefabGameObject()
		{
			return null;
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B5")]
		[Address(RVA = "0x79D4", Offset = "0x79D4", VA = "0x79D4")]
		public MedalsGridWithCategoriesParams()
		{
		}

		// Token: 0x04001679 RID: 5753
		[Token(Token = "0x4001679")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _cellGroupPrefab;
	}
}
