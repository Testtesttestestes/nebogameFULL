using System;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Aprs.View.DiscountWidget
{
	// Token: 0x02000D5C RID: 3420
	[Token(Token = "0x2000D5C")]
	public class AprDiscountHolder : MonoBehaviour, IAprDiscountWidget
	{
		// Token: 0x060053CE RID: 21454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CE")]
		[Address(RVA = "0xA18B", Offset = "0xA18B", VA = "0xA18B", Slot = "4")]
		public void SetData(IAprDataDiscountProvider data)
		{
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CF")]
		[Address(RVA = "0xA18C", Offset = "0xA18C", VA = "0xA18C")]
		public AprDiscountHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_View_DiscountWidget_AprDiscountHolder___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  double dVar5;
		  int *piVar6;
		  double dVar7;
		  double param1_00;
		  int iVar8;
		  int iVar9;
		  uint uVar10;
		  ulonglong uVar11;
		  float8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a59426 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6163);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59426 = '\x01';
		  }
		  local_10 = 0.0;
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81000871;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo,0)
		  ;
		code_r0x81000871:
		  uVar1 = CONCAT44(in_register_20000004,param2);
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (iVar8 == 0) {
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		  }
		  else {
		    uVar10 = 0;
		    iVar8 = *param2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 200);
		          goto code_r0x810008ef;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo,
		                                  1);
		code_r0x810008ef:
		    uVar1 = CONCAT44(uVar4,param2);
		    iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		    uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar8 = *(int *)(iVar8 + 0x24);
		    uVar10 = 0;
		    iVar9 = *param2;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 200);
		          goto code_r0x81000970;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo,
		                                  1);
		code_r0x81000970:
		    uVar1 = CONCAT44(uVar4,param2);
		    iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		    iVar9 = *(int *)(iVar9 + 0x20);
		    uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(iVar9 == iVar8),0);
		    if (iVar9 == iVar8) {
		      uVar3 = *(undefined4 *)(param1 + 0x10);
		      iVar8 = *param2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          if (Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 200);
		            goto code_r0x81000a10;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,
		                                    Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo,1);
		code_r0x81000a10:
		      uVar1 = CONCAT44(uVar4,param2);
		      iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		      uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      if (*(int *)(iVar8 + 0x30) == 0) {
		        param2_00 = 0;
		      }
		      else {
		        param2_00 = Core_Extensions_Dict_RewardInfoExt___cctor(*(int *)(iVar8 + 0x30),0);
		      }
		      Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar3,param2_00,0);
		      piVar6 = *(int **)(param1 + 0x14);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar10 = 0;
		      uVar3 = func_ii_7508(StringLiteral_6163,1,0,1,0,0,0,0);
		      iVar8 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		      iVar9 = *param2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 200);
		            goto code_r0x81000aee;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,
		                                    Gameplay_Discounts_Model_IAprDataDiscountProvider_TypeInfo,1);
		code_r0x81000aee:
		      iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar4,param2),puVar2[1]);
		      dVar7 = *(double *)(*(int *)(*(int *)(iVar9 + 0x14) + 0x10) + 0x60);
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      param1_00 = (1.0 - dVar7) * 100.0;
		      dVar7 = param1_00;
		      dVar5 = unnamed_function_4206(param1_00,&local_8);
		      local_10 = local_8;
		      if (0.0 <= param1_00) {
		        if (dVar5 == 0.5) {
		          if (ABS((double)local_8) < 9.223372036854776e+18) {
		            uVar11 = (ulonglong)(double)local_8;
		          }
		          else {
		            uVar11 = 0;
		          }
		          if ((uVar11 & 1) != 0) {
		            local_10 = (float8)((double)local_8 + 1.0);
		          }
		        }
		        else {
		          local_10 = (float8)FLOOR(param1_00 + 0.5);
		        }
		      }
		      else if (dVar5 == -0.5) {
		        if (ABS((double)local_8) < 9.223372036854776e+18) {
		          uVar11 = (ulonglong)(double)local_8;
		        }
		        else {
		          uVar11 = 0;
		        }
		        if ((uVar11 & 1) != 0) {
		          local_10 = (float8)((double)local_8 + -1.0);
		        }
		      }
		      else {
		        local_10 = (float8)CEIL(param1_00 + -0.5);
		      }
		      uVar4 = (undefined4)((ulonglong)dVar7 >> 0x20);
		      iVar9 = func_ii_7515(&local_10,0);
		      local_8 = 0.0;
		      if (iVar9 == 0) {
		        iVar9 = StringLiteral_5;
		      }
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_8,StringLiteral_28217,iVar9,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(float8 *)(iVar8 + 0x10) = local_8;
		      uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                        (uVar3,iVar8,0);
		      iVar8 = *piVar6;
		      (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		                (CONCAT44(uVar4,piVar6),uVar3,*(undefined4 *)(iVar8 + 0x2d4));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DetailAprDiscountView _discountView;
	}
}
