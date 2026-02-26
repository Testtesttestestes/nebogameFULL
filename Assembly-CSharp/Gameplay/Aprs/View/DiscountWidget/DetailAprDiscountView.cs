using System;
using AssetContent;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Aprs.View.DiscountWidget
{
	// Token: 0x02000D5D RID: 3421
	[Token(Token = "0x2000D5D")]
	public class DetailAprDiscountView : MonoBehaviour, IAprDiscountWidget
	{
		// Token: 0x060053D0 RID: 21456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D0")]
		[Address(RVA = "0xA18D", Offset = "0xA18D", VA = "0xA18D", Slot = "4")]
		public void SetData(IAprDataDiscountProvider data)
		{
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D1")]
		[Address(RVA = "0xA18E", Offset = "0xA18E", VA = "0xA18E")]
		public DetailAprDiscountView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_View_DiscountWidget_DetailAprDiscountView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a59427 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo);
		    DAT_ram_00a59427 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81000d37;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo,0)
		  ;
		code_r0x81000d37:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _saleWidgetText;
	}
}
