using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers.UserSkills
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	public class UserSkillsRewardRender : AbstractRewardRender
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x5EB6", Offset = "0x5EB6", VA = "0x5EB6", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x5EB7", Offset = "0x5EB7", VA = "0x5EB7")]
		public UserSkillsRewardRender()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_UserSkills_UserSkillsRewardRender___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int param1_00;
		  undefined4 param2_00;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  double dVar9;
		  double dVar10;
		  int iVar11;
		  int param2_01;
		  longlong lVar12;
		  int *piVar13;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a59a34 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_RewardTypes__get_Value__);
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils_TypeInfo);
		    DAT_ram_00a59a34 = '\x01';
		  }
		  local_8 = 0;
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xf4));
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,uVar2);
		  uVar1 = (uint)((ulonglong)uVar2 >> 0x20);
		  uVar4 = func_ii_7225(uVar4,0);
		  uVar4 = Core_Extensions_RatingTypesDicExt__GetHint(uVar4,0);
		  lVar12 = (ulonglong)uVar1 << 0x20;
		  param1_00 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds(uVar4,0);
		  iVar11 = *(int *)(param1_00 + 0xc);
		  if (0 < iVar11) {
		    do {
		      uVar3 = (undefined4)((ulonglong)lVar12 >> 0x20);
		      param2_00 = System_Linq_Enumerable__ToList_object_
		                            (param1_00,param2_01,
		                             Method_System_Collections_Generic_List_Resources__get_Item__);
		      if (*(int *)(Utils_ResourceRewardsUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_ResourceRewardsUtils_TypeInfo);
		      }
		      Utils_ResourceRewardsUtils__GetRewardToResourceDict(&local_10,param2_00,0);
		      local_8 = local_10;
		      uVar5 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                        (&local_8,Method_System_Nullable_RewardTypes__get_Value__);
		      uVar5 = Core_Data_RewardData___ctor(uVar5,0);
		      iVar6 = func_ii_8038(uVar5,0);
		      if (iVar6 - 1U < 2) {
		        dVar10 = func_ii_6906(uVar4,param2_00,0);
		        dVar9 = Utils_LongTap__DetectStartLongTapCoroutine_d__41__System_Collections_IEnumerator_get_Current
		                          (param2_00,dVar10,1,0);
		        if (ABS(dVar9) < 9.223372036854776e+18) {
		          lVar12 = (longlong)dVar9;
		        }
		        else {
		          lVar12 = -0x8000000000000000;
		        }
		        uVar3 = (undefined4)((ulonglong)dVar10 >> 0x20);
		        piVar7 = (int *)func_ii_7225(uVar5,0);
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar13) {
		              puVar8 = (uint *)(piVar13[1] * 8 + iVar6 + 0xd0);
		              goto code_r0x810b0828;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b0828:
		        piVar7 = (int *)(**(code **)((ulonglong)*puVar8 * 4))(piVar7,CONCAT44(uVar3,puVar8[1]));
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_ICollection_long__TypeInfo == *piVar13) {
		              puVar8 = (uint *)(piVar13[1] * 8 + iVar6 + 0xd0);
		              goto code_r0x810b08a4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_ICollection_long__TypeInfo,2
		                                     );
		code_r0x810b08a4:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,lVar12,puVar8[1]);
		        uVar3 = (undefined4)((ulonglong)lVar12 >> 0x20);
		      }
		      else {
		        piVar7 = (int *)func_ii_7225(uVar5,0);
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar13) {
		              puVar8 = (uint *)(piVar13[1] * 8 + iVar6 + 0xd0);
		              goto code_r0x810b0929;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b0929:
		        piVar7 = (int *)(**(code **)((ulonglong)*puVar8 * 4))(piVar7,CONCAT44(uVar3,puVar8[1]));
		        dVar10 = func_ii_6906(uVar4,param2_00,0);
		        if (ABS(dVar10) < 9.223372036854776e+18) {
		          lVar12 = (longlong)dVar10;
		        }
		        else {
		          lVar12 = -0x8000000000000000;
		        }
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_ICollection_long__TypeInfo == *piVar13) {
		              puVar8 = (uint *)(piVar13[1] * 8 + iVar6 + 0xd0);
		              goto code_r0x810b09d4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_ICollection_long__TypeInfo,2
		                                     );
		code_r0x810b09d4:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,lVar12,puVar8[1]);
		        uVar3 = (undefined4)((ulonglong)lVar12 >> 0x20);
		      }
		      iVar6 = *(int *)param1[5];
		      lVar12 = CONCAT44(uVar3,param1[4]);
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0xe8) * 4))
		                ((int *)param1[5],lVar12,uVar5,*(undefined4 *)(iVar6 + 0xec));
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar11);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _skillsOwner;
	}
}
