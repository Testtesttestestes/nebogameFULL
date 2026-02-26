using System;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	public class AppearRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x5E85", Offset = "0x5E85", VA = "0x5E85", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x5E86", Offset = "0x5E86", VA = "0x5E86")]
		public AppearRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_AppearRewardRenderer___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  uint uVar9;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a59a17 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AprView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a17 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  piVar2 = (int *)func_ii_7225(uVar1,0);
		  iVar6 = *piVar2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x810aa48a;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810aa48a:
		  piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  uVar9 = 0;
		  iVar6 = *piVar2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810aa508;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_long__TypeInfo,0);
		code_r0x810aa508:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  if (0 < iVar6) {
		    do {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		      piVar2 = (int *)func_ii_7225(uVar1,0);
		      iVar7 = *piVar2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar4 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		          if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar4) {
		            puVar3 = (uint *)(piVar4[1] * 8 + iVar7 + 0xd0);
		            goto code_r0x810aa5a7;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810aa5a7:
		      piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      iVar7 = *piVar2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar4 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar4) {
		            puVar3 = (uint *)(iVar7 + piVar4[1] * 8 + 0xc0);
		            goto code_r0x810aa623;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810aa623:
		      uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,iVar5,puVar3[1]);
		      iVar7 = param1[10];
		      param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (param1[4],0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      piVar2 = (int *)func_ii_6805(iVar7,param2_00,Method_UnityEngine_Object_Instantiate_AprView___)
		      ;
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *piVar4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		            puVar3 = (uint *)(piVar8[1] * 8 + iVar7 + 0x178);
		            goto code_r0x810aa709;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810aa709:
		      iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      uVar1 = func_ii_7730(*(undefined4 *)(*(int *)(iVar7 + 0x24) + 0x14),uVar1,
		                           Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                          );
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x138) * 4))
		                (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x13c));
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar6);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AprView _aprViewPrefab;
	}
}
