using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	public class BuildingPriceItemView : MonoBehaviour
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024B")]
		public ResourcesDic Resource
		{
			[Token(Token = "0x600101B")]
			[Address(RVA = "0x6225", Offset = "0x6225", VA = "0x6225")]
			get
			{
				return null;
			}
			[Token(Token = "0x600101C")]
			[Address(RVA = "0x6226", Offset = "0x6226", VA = "0x6226")]
			set
			{
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00004590 File Offset: 0x00002790
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024C")]
		public double Value
		{
			[Token(Token = "0x600101D")]
			[Address(RVA = "0x6227", Offset = "0x6227", VA = "0x6227")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600101E")]
			[Address(RVA = "0x6228", Offset = "0x6228", VA = "0x6228")]
			set
			{
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600101F")]
		[Address(RVA = "0x6229", Offset = "0x6229", VA = "0x6229")]
		public BuildingPriceItemView()
		{
		}

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImageLoader _gameRawImageLoader;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x18")]
		private ResourcesDic _resource;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x20")]
		private double _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Resource ---
		void UI_Windows_Buildings_BuildingPriceItemView__get_Resource
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a9d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a58a9d = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = func_ii_7611(param2,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (param1_00,param2_00,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: get_Value ---
		void UI_Windows_Buildings_BuildingPriceItemView__get_Value
		               (int param1,double param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  *(double *)(param1 + 0x20) = param2;
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = func_ii_7515(param1 + 0x20,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

}
