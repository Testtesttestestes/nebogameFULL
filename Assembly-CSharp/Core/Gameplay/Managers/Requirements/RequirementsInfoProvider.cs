using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;

namespace Core.Gameplay.Managers.Requirements
{
	// Token: 0x02001195 RID: 4501
	[Token(Token = "0x2001195")]
	public class RequirementsInfoProvider : AbstractUserInformationProvider
	{
		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006AF4 RID: 27380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D9")]
		public IInformationProvider CostProvider
		{
			[Token(Token = "0x6006AF3")]
			[Address(RVA = "0xB5FB", Offset = "0xB5FB", VA = "0xB5FB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AF4")]
			[Address(RVA = "0xB5FC", Offset = "0xB5FC", VA = "0xB5FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF5")]
		[Address(RVA = "0xB5FD", Offset = "0xB5FD", VA = "0xB5FD", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  Core_Data_InfoRows_AbstractUserInformationProvider__Dispose(param1,param2,param3,0);
		  *(undefined4 *)(param1 + 0x20) = param6;
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x2c) = param4;
		  return;
		}
		*/

		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF6")]
		[Address(RVA = "0xB5FE", Offset = "0xB5FE", VA = "0xB5FE")]
		public RequirementsInfoProvider([NotNull] UserData user, [NotNull] UserData loggedUser, IInformationProvider costProvider, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a638da == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13141);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13142);
		    DAT_ram_00a638da = '\x01';
		  }
		  iVar5 = param1[0xb];
		  if (iVar5 != 0) {
		    uVar1 = 0;
		    iVar7 = param1[2];
		    piVar8 = (int *)param1[4];
		    iVar6 = *piVar8;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x823128f8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,0);
		code_r0x823128f8:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,iVar5,puVar4[1]);
		  }
		  if (param1[9] == 0) {
		    iVar5 = param1[2];
		    piVar8 = (int *)param1[4];
		    uVar1 = 0;
		    uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                      (param1,0);
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x823129a3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,2);
		code_r0x823129a3:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		  }
		  else {
		    iVar5 = System_Collections_CollectionBase___ctor
		                      (param1[9],**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		    iVar7 = param1[2];
		    piVar8 = (int *)param1[4];
		    if (iVar5 == 0) {
		      iVar5 = *param1;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (param1,param1[9],*(undefined4 *)(iVar5 + 0x104));
		      uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                        (param1,iVar5);
		      iVar5 = *piVar8;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x82312b4f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,1);
		code_r0x82312b4f:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    }
		    else {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_13142,1,0,1,0,0,0,0);
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = 0;
		      uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                        (param1,0);
		      iVar5 = *piVar8;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x82312aa3;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,1);
		code_r0x82312aa3:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    }
		  }
		  iVar5 = param1[10];
		  if (iVar5 == 0) {
		    iVar5 = param1[2];
		    piVar8 = (int *)param1[4];
		    uVar1 = 0;
		    uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions(param1,0);
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x82312bf1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,2);
		code_r0x82312bf1:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		    iVar5 = param1[10];
		    if (iVar5 == 0) {
		      iVar5 = param1[2];
		      piVar8 = (int *)param1[4];
		      uVar1 = 0;
		      uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions
		                        (param1,0);
		      iVar7 = *piVar8;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		            goto code_r0x82312c90;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,2);
		code_r0x82312c90:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		      return;
		    }
		  }
		  iVar5 = System_Collections_CollectionBase___ctor
		                    (iVar5,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  iVar7 = param1[2];
		  piVar8 = (int *)param1[4];
		  if (iVar5 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_13141,1,0,1,0,0,0,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions(param1,0);
		    iVar5 = *piVar8;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x82312d8f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,1);
		code_r0x82312d8f:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    return;
		  }
		  iVar5 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (param1,param1[10],*(undefined4 *)(iVar5 + 0x104));
		  uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions
		                    (param1,iVar5);
		  iVar5 = *piVar8;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x82312e3a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x82312e3a:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a638da == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13141);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13142);
		    DAT_ram_00a638da = '\x01';
		  }
		  iVar5 = param1[0xb];
		  if (iVar5 != 0) {
		    uVar1 = 0;
		    iVar7 = param1[2];
		    piVar8 = (int *)param1[4];
		    iVar6 = *piVar8;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x823128f8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,0);
		code_r0x823128f8:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,iVar5,puVar4[1]);
		  }
		  if (param1[9] == 0) {
		    iVar5 = param1[2];
		    piVar8 = (int *)param1[4];
		    uVar1 = 0;
		    uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                      (param1,0);
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x823129a3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,2);
		code_r0x823129a3:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		  }
		  else {
		    iVar5 = System_Collections_CollectionBase___ctor
		                      (param1[9],**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		    iVar7 = param1[2];
		    piVar8 = (int *)param1[4];
		    if (iVar5 == 0) {
		      iVar5 = *param1;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (param1,param1[9],*(undefined4 *)(iVar5 + 0x104));
		      uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                        (param1,iVar5);
		      iVar5 = *piVar8;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x82312b4f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,1);
		code_r0x82312b4f:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    }
		    else {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_13142,1,0,1,0,0,0,0);
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = 0;
		      uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                        (param1,0);
		      iVar5 = *piVar8;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x82312aa3;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,1);
		code_r0x82312aa3:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    }
		  }
		  iVar5 = param1[10];
		  if (iVar5 == 0) {
		    iVar5 = param1[2];
		    piVar8 = (int *)param1[4];
		    uVar1 = 0;
		    uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions(param1,0);
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x82312bf1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,2);
		code_r0x82312bf1:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		    iVar5 = param1[10];
		    if (iVar5 == 0) {
		      iVar5 = param1[2];
		      piVar8 = (int *)param1[4];
		      uVar1 = 0;
		      uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions
		                        (param1,0);
		      iVar7 = *piVar8;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		            goto code_r0x82312c90;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,2);
		code_r0x82312c90:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		      return;
		    }
		  }
		  iVar5 = System_Collections_CollectionBase___ctor
		                    (iVar5,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  iVar7 = param1[2];
		  piVar8 = (int *)param1[4];
		  if (iVar5 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_13141,1,0,1,0,0,0,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions(param1,0);
		    iVar5 = *piVar8;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x82312d8f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,1);
		code_r0x82312d8f:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    return;
		  }
		  iVar5 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (param1,param1[10],*(undefined4 *)(iVar5 + 0x104));
		  uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions
		                    (param1,iVar5);
		  iVar5 = *piVar8;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x82312e3a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x82312e3a:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a638da == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13141);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13142);
		    DAT_ram_00a638da = '\x01';
		  }
		  iVar5 = param1[0xb];
		  if (iVar5 != 0) {
		    uVar1 = 0;
		    iVar7 = param1[2];
		    piVar8 = (int *)param1[4];
		    iVar6 = *piVar8;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x823128f8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,0);
		code_r0x823128f8:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,iVar5,puVar4[1]);
		  }
		  if (param1[9] == 0) {
		    iVar5 = param1[2];
		    piVar8 = (int *)param1[4];
		    uVar1 = 0;
		    uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                      (param1,0);
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x823129a3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,2);
		code_r0x823129a3:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		  }
		  else {
		    iVar5 = System_Collections_CollectionBase___ctor
		                      (param1[9],**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		    iVar7 = param1[2];
		    piVar8 = (int *)param1[4];
		    if (iVar5 == 0) {
		      iVar5 = *param1;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (param1,param1[9],*(undefined4 *)(iVar5 + 0x104));
		      uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                        (param1,iVar5);
		      iVar5 = *piVar8;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x82312b4f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,1);
		code_r0x82312b4f:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    }
		    else {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_13142,1,0,1,0,0,0,0);
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = 0;
		      uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		                        (param1,0);
		      iVar5 = *piVar8;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		            goto code_r0x82312aa3;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,1);
		code_r0x82312aa3:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    }
		  }
		  iVar5 = param1[10];
		  if (iVar5 == 0) {
		    iVar5 = param1[2];
		    piVar8 = (int *)param1[4];
		    uVar1 = 0;
		    uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions(param1,0);
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x82312bf1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,2);
		code_r0x82312bf1:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		    iVar5 = param1[10];
		    if (iVar5 == 0) {
		      iVar5 = param1[2];
		      piVar8 = (int *)param1[4];
		      uVar1 = 0;
		      uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions
		                        (param1,0);
		      iVar7 = *piVar8;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		            goto code_r0x82312c90;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,
		                                    Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                    ,2);
		code_r0x82312c90:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar5,uVar2,puVar4[1]);
		      return;
		    }
		  }
		  iVar5 = System_Collections_CollectionBase___ctor
		                    (iVar5,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  iVar7 = param1[2];
		  piVar8 = (int *)param1[4];
		  if (iVar5 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_13141,1,0,1,0,0,0,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions(param1,0);
		    iVar5 = *piVar8;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x82312d8f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,1);
		code_r0x82312d8f:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		    return;
		  }
		  iVar5 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (param1,param1[10],*(undefined4 *)(iVar5 + 0x104));
		  uVar3 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions
		                    (param1,iVar5);
		  iVar5 = *piVar8;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x82312e3a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x82312e3a:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar8,iVar7,uVar2,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF7")]
		[Address(RVA = "0xB5FF", Offset = "0xB5FF", VA = "0xB5FF")]
		public RequirementsInfoProvider([NotNull] UserData user, [NotNull] UserData loggedUser, IList<RestrictionInfo> restrictionInfos)
		{
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0xB600", Offset = "0xB600", VA = "0xB600")]
		public RequirementsInfoProvider([NotNull] UserData user, [NotNull] UserData loggedUser, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
		{
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AF9")]
		[Address(RVA = "0xB601", Offset = "0xB601", VA = "0xB601", Slot = "9")]
		protected override void PrepareInformation()
		{
		/* --- GHIDRA: PrepareInformation ---
		int Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__PrepareInformation
		              (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param3;
		  int param1_00;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  uint uVar10;
		  int iVar11;
		  longlong lVar12;
		  longlong lVar13;
		  double param1_01;
		  int iVar14;
		  int *piVar15;
		  ushort local_6;
		  int local_4;
		  
		  iVar14 = 0;
		  iVar11 = 0;
		  if (DAT_ram_00a638db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28135);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25212);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26379);
		    DAT_ram_00a638db = '\x01';
		  }
		  local_4 = 0;
		  piVar6 = *(int **)(param1 + 0x1c);
		  if (piVar6 != (int *)0x0) {
		    uVar10 = 0;
		    iVar14 = *piVar6;
		    if (*(ushort *)(iVar14 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_RestrictionInfo__TypeInfo ==
		            *(int *)(*(int *)(iVar14 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(iVar14 + *(int *)(*(int *)(iVar14 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82312f80;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar14 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,
		                                  System_Collections_Generic_ICollection_RestrictionInfo__TypeInfo,0
		                                 );
		code_r0x82312f80:
		    uVar1 = CONCAT44(in_register_20000004,piVar6);
		    iVar14 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		    if (iVar14 < 1) {
		      iVar14 = 0;
		    }
		    else {
		      uVar10 = 0;
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      iVar14 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar14,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		      piVar6 = *(int **)(param1 + 0x1c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_ICollection_RestrictionInfo__TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		            puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x82313023;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar6,
		                                    System_Collections_Generic_ICollection_RestrictionInfo__TypeInfo
		                                    ,0);
		code_r0x82313023:
		      uVar1 = CONCAT44(uVar3,piVar6);
		      iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		      if (0 < iVar7) {
		        do {
		          uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		          piVar6 = *(int **)(param1 + 0x1c);
		          iVar8 = *piVar6;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar10 = 0;
		            do {
		              piVar15 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		              if (System_Collections_Generic_IList_RestrictionInfo__TypeInfo == *piVar15) {
		                puVar2 = (uint *)(iVar8 + piVar15[1] * 8 + 0xc0);
		                goto code_r0x823130ab;
		              }
		              uVar10 = uVar10 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar6,
		                                        System_Collections_Generic_IList_RestrictionInfo__TypeInfo,0
		                                       );
		code_r0x823130ab:
		          uVar1 = CONCAT44(uVar3,piVar6);
		          iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,iVar11,puVar2[1]);
		          uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		          piVar6 = (int *)Core_Gameplay_Managers_UserManager__get_User
		                                    (*(undefined4 *)(param1 + 0xc),0);
		          (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x100) * 4))
		                    (CONCAT44(uVar3,piVar6),*(undefined4 *)(iVar8 + 0xc),&local_4,
		                     *(undefined4 *)(*piVar6 + 0x104));
		          lVar12 = *(longlong *)(iVar8 + 0x10);
		          lVar13 = *(longlong *)(local_4 + 0x10);
		          uVar3 = func_ii_8770(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(local_4 + 0xc),0);
		          uVar3 = Core_Extensions_Dict_TreeBonusAnimationExt__GetEnergyAssetId(uVar3,0);
		          uVar4 = unnamed_function_1417
		                            (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		          System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                    (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		          if (lVar12 <= lVar13) {
		            lVar13 = lVar12;
		          }
		          if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Utils_StringUtils_TypeInfo);
		          }
		          uVar5 = UI_SimpleIconValue__set_IconAssetId((double)lVar12,StringLiteral_28780,0);
		          System_Reflection_FieldInfo__get_IsStatic
		                    (uVar4,StringLiteral_27779,uVar5,
		                     Method_System_Collections_Generic_Dictionary_string__string__Add__);
		          uVar5 = UI_SimpleIconValue__set_IconAssetId((double)lVar13,StringLiteral_28780,0);
		          System_Reflection_FieldInfo__get_IsStatic
		                    (uVar4,StringLiteral_22118,uVar5,
		                     Method_System_Collections_Generic_Dictionary_string__string__Add__);
		          uVar5 = UI_SimpleIconValue__set_IconAssetId
		                            ((double)(lVar12 - lVar13),StringLiteral_28780,0);
		          System_Reflection_FieldInfo__get_IsStatic
		                    (uVar4,StringLiteral_26379,uVar5,
		                     Method_System_Collections_Generic_Dictionary_string__string__Add__);
		          uVar5 = UI_SimpleIconValue__set_IconAssetId
		                            ((double)*(longlong *)(iVar8 + 0x10),StringLiteral_28780,0);
		          System_Reflection_FieldInfo__get_IsStatic
		                    (uVar4,StringLiteral_25212,uVar5,
		                     Method_System_Collections_Generic_Dictionary_string__string__Add__);
		          param1_01 = (double)*(longlong *)(iVar8 + 0x18);
		          param3 = UI_SimpleIconValue__set_IconAssetId(param1_01,StringLiteral_28780,0);
		          uVar5 = (undefined4)((ulonglong)param1_01 >> 0x20);
		          System_Reflection_FieldInfo__get_IsStatic
		                    (uVar4,StringLiteral_28135,param3,
		                     Method_System_Collections_Generic_Dictionary_string__string__Add__);
		          uVar4 = Core_GameLocalization__GetTranslation(uVar3,uVar4,0);
		          param1_00 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		          uVar1 = CONCAT44(uVar5,param1_00);
		          System_Collections_Generic_List_object____ctor(param1_00,0);
		          uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		          *(undefined4 *)(param1_00 + 0xc) = uVar4;
		          if (*(int *)(param1 + 0x18) == *(int *)(param1 + 0xc)) {
		            if (DAT_ram_00a6456f == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		              DAT_ram_00a6456f = '\x01';
		            }
		            piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		            iVar9 = *piVar6;
		            if (*(ushort *)(iVar9 + 0xb6) != 0) {
		              uVar10 = 0;
		              do {
		                piVar15 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		                if (Core_Gameplay_IGame_TypeInfo == *piVar15) {
		                  puVar2 = (uint *)(piVar15[1] * 8 + iVar9 + 0x160);
		                  goto code_r0x823132fc;
		                }
		                uVar10 = uVar10 + 1;
		              } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		            }
		            puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x823132fc:
		            uVar1 = CONCAT44(uVar3,piVar6);
		            uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(uVar1,puVar2[1]);
		            uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		            uVar4 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestrictions
		                              (uVar4,iVar8,local_4,0);
		            local_6 = 0;
		            uVar1 = CONCAT44(uVar3,&local_6);
		            System_Data_SqlTypes_SqlByte__ToSqlInt64
		                      (&local_6,uVar4,Method_System_Nullable_bool___ctor__);
		            *(ushort *)(param1_00 + 0x10) = local_6;
		          }
		          iVar8 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		          *(int *)(iVar14 + 0x10) = *(int *)(iVar14 + 0x10) + 1;
		          uVar10 = *(uint *)(iVar14 + 0xc);
		          if (uVar10 < *(uint *)(*(int *)(iVar14 + 8) + 0xc)) {
		            *(uint *)(iVar14 + 0xc) = uVar10 + 1;
		            *(int *)(*(int *)(iVar14 + 8) + uVar10 * 4 + 0x10) = param1_00;
		          }
		          else {
		            uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),iVar14);
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar14,param1_00,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		          }
		          iVar11 = iVar11 + 1;
		        } while (iVar11 != iVar7);
		      }
		    }
		  }
		  return iVar14;
		}
		*/

		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006AFA")]
		[Address(RVA = "0xB602", Offset = "0xB602", VA = "0xB602")]
		public List<IInformationRow> GetRestrictions()
		{
		/* --- GHIDRA: GetRestrictions ---
		/* WARNING: Removing unreachable block (ram,0x8231403b) */
		
		int Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__GetRestrictions
		              (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  undefined4 uVar13;
		  int *piVar14;
		  ushort local_1a;
		  int local_18;
		  int **local_14;
		  uint local_10;
		  uint local_c;
		  uint local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a638dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SingleOrDefault_MedalInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0__GetMaterials_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1680);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a638dc = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  local_c = 0;
		  local_10 = 0;
		  if (*(int *)(param1 + 0x20) == 0) {
		    return 0;
		  }
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		  piVar10 = *(int **)(param1 + 0x20);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_RewardInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x82313517;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar10,System_Collections_Generic_IEnumerable_RewardInfo__TypeInfo,
		                                0);
		code_r0x82313517:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		  local_18 = 0;
		  local_14 = &local_4;
		code_r0x82313542:
		  piVar10 = local_4;
		  iVar11 = *local_4;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		        puVar3 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		        goto code_r0x823135e8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x82313630:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x82313c4a;
		  }
		code_r0x823135e8:
		  DAT_ram_009d3e38 = 0;
		  iVar11 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		  piVar10 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x82313630;
		  if (iVar11 == 0) {
		    iVar11 = 9;
		    goto code_r0x82313c97;
		  }
		  iVar11 = *local_4;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		      if (System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo == *piVar14) {
		        puVar3 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		        goto code_r0x823136d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo,0);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x823136d7:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x82313721;
		    if (*(int *)(iVar11 + 0xc) == 0xc) {
		      uVar1 = 0;
		      iVar6 = *(int *)(*(int *)(iVar11 + 0x10) + 0xc);
		      if (0 < iVar6) {
		code_r0x82313744:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x273,
		                           *(undefined4 *)(iVar11 + 0x10),uVar1,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar12 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82313c4a;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x273,
		                           *(undefined4 *)(iVar11 + 0x10),uVar1 | 1,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar12 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x82313c4a;
		        }
		        local_8 = uVar5;
		        if (iVar7 == 0) {
		code_r0x82313c28:
		          uVar1 = uVar1 + 2;
		          if (iVar6 <= (int)uVar1) goto code_r0x82313542;
		          goto code_r0x82313744;
		        }
		        if (DAT_ram_00a6456f == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		          iVar12 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar12 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x82313c4a;
		          }
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar5 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar12 + 0x58) + uVar5 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar14) {
		              puVar3 = (undefined4 *)(piVar14[1] * 8 + iVar12 + 0x120);
		              goto code_r0x823138eb;
		            }
		            uVar5 = uVar5 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar5);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                            Core_Gameplay_IGame_TypeInfo,0xc);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x823138eb:
		          DAT_ram_009d3e38 = 0;
		          iVar12 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::invoke_iiii
		                              (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x20,
		                               *(undefined4 *)(iVar12 + 0x10),iVar7,0);
		            iVar12 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar12 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x82313c4a;
		            }
		            DAT_ram_009d3e38 = 0;
		            local_c = uVar5;
		            iVar12 = import::env::invoke_ii
		                               (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                Core_Data_InfoRows_ValueRow_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              System_Collections_Generic_List_object____ctor(iVar12,0);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_iiii
		                                  (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x21,
		                                   *(undefined4 *)(param1 + 0x14),iVar7,0);
		                iVar7 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar7 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x82313c4a;
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_iii
		                                  (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x22,uVar4,0);
		                iVar7 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar7 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x82313c4a;
		                }
		                *(undefined4 *)(iVar12 + 0xc) = uVar4;
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_c,
		                                   0);
		                iVar7 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar7 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x82313c4a;
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar13 = import::env::invoke_iii
		                                   (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_8
		                                    ,0);
		                iVar7 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar7 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x82313c4a;
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_iiiii
		                                  (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26e,uVar4,
		                                   StringLiteral_1618,uVar13,0);
		                iVar7 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar7 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x82313c4a;
		                }
		                *(undefined4 *)(iVar12 + 0x18) = uVar4;
		                if (*(int *)(param1 + 0x18) == *(int *)(param1 + 0xc)) {
		                  DAT_ram_009d3e38 = 0;
		                  local_1a = 0;
		                  System_Data_SqlTypes_SqlByte__ToSqlInt64
		                            (&local_1a,(uint)(local_8 <= local_c),
		                             Method_System_Nullable_bool___ctor__);
		                  iVar7 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar7 == 1) {
		                    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x82313c4a;
		                  }
		                  *(ushort *)(iVar12 + 0x10) = local_1a;
		                }
		                iVar7 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		                *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		                uVar5 = *(uint *)(param1_00 + 0xc);
		                if (*(uint *)(*(int *)(param1_00 + 8) + 0xc) <= uVar5) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,iVar12
		                             ,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		                  iVar12 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar12 != 1) goto code_r0x82313c28;
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x82313c4a;
		                }
		                *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		                *(int *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = iVar12;
		                goto code_r0x82313c28;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x82313c4a;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x82313c4a;
		      }
		    }
		    goto code_r0x82313542;
		  }
		code_r0x82313721:
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82313c4a:
		  iVar11 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar6) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_18 = *piVar10;
		    iVar11 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x82313c97:
		      DAT_ram_009d3e38 = 0;
		      piVar10 = *local_14;
		      if (piVar10 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *piVar10;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x82313d12;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x82313d12:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		      }
		      if (local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar11 != 0) &&
		         ((((((iVar11 == 1 || (iVar11 == 2)) || (iVar11 == 3)) || ((iVar11 == 4 || (iVar11 == 5))))
		           || ((iVar11 == 6 || ((iVar11 == 7 || (iVar11 == 8)))))) || (iVar11 != 9)))) {
		        return param1_00;
		      }
		      uVar1 = 0;
		      piVar10 = *(int **)(param1 + 0x20);
		      iVar11 = *piVar10;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_RewardInfo__TypeInfo ==
		              *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x82313dae;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar10,
		                                    System_Collections_Generic_IEnumerable_RewardInfo__TypeInfo,0);
		code_r0x82313dae:
		      local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		      local_18 = 0;
		      local_14 = &local_4;
		code_r0x82313dd9:
		      piVar10 = local_4;
		      iVar11 = *local_4;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		            puVar3 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		            goto code_r0x82313e7d;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x82313ec1:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x823143d3;
		      }
		code_r0x82313e7d:
		      DAT_ram_009d3e38 = 0;
		      iVar11 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		      piVar10 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82313ec1;
		      if (iVar11 == 0) goto code_r0x8231441c;
		      iVar11 = *local_4;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo == *piVar14) {
		            puVar3 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		            goto code_r0x82313f68;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x82313f68:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x82313fb3;
		        if (*(int *)(iVar11 + 0xc) == 0x6e) {
		          iVar6 = 0;
		          iVar12 = *(int *)(*(int *)(iVar11 + 0x10) + 0xc);
		          if (0 < iVar12) {
		            do {
		              DAT_ram_009d3e38 = 0;
		              iVar7 = import::env::invoke_ii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                 Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0_TypeInfo
		                                );
		              if (DAT_ram_009d3e38 == 1) {
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x273,
		                                 *(undefined4 *)(iVar11 + 0x10),iVar6,
		                                 Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		              iVar9 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar9 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              *(undefined4 *)(iVar7 + 8) = uVar4;
		              uVar13 = *(undefined4 *)(*(int *)(param1 + 0xc) + 0x40);
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_ii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                 System_Func_MedalInfo__bool__TypeInfo);
		              if (DAT_ram_009d3e38 == 1) {
		code_r0x823141bc:
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar4,iVar7,
		                         Method_Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0__GetMaterials_b__0__
		                         ,0);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x823141bc;
		              DAT_ram_009d3e38 = 0;
		              iVar8 = import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x339,uVar13,
		                                 uVar4,Method_System_Linq_Enumerable_SingleOrDefault_MedalInfo___);
		              iVar9 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar9 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              DAT_ram_009d3e38 = 0;
		              local_10 = (uint)(iVar8 != 0);
		              iVar9 = import::env::invoke_ii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                 Core_Data_InfoRows_ValueRow_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) {
		code_r0x8231419e:
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              DAT_ram_009d3e38 = 0;
		              System_Collections_Generic_List_object____ctor(iVar9,0);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x8231419e;
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iiii
		                                (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x24,
		                                 *(undefined4 *)(param1 + 0x14),*(undefined4 *)(iVar7 + 8),0);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iii
		                                (s___Scripting__UnityEngine__Render_ram_000036af + 0x38,uVar4,0);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              *(undefined4 *)(iVar9 + 0xc) = uVar4;
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1d8,&local_10,0
		                                );
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iiii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,uVar4,
		                                 StringLiteral_1680,0);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              *(undefined4 *)(iVar9 + 0x18) = uVar4;
		              DAT_ram_009d3e38 = 0;
		              local_1a = 0;
		              System_Data_SqlTypes_SqlByte__ToSqlInt64
		                        (&local_1a,(uint)(0 < (int)local_10),Method_System_Nullable_bool___ctor__);
		              if (DAT_ram_009d3e38 == 1) {
		code_r0x823143cb:
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x823143d3;
		              }
		              *(ushort *)(iVar9 + 0x10) = local_1a;
		              iVar7 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		              *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		              uVar1 = *(uint *)(param1_00 + 0xc);
		              if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		                *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		                *(int *)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = iVar9;
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,iVar9,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		                if (DAT_ram_009d3e38 == 1) goto code_r0x823143cb;
		              }
		              iVar6 = iVar6 + 1;
		            } while (iVar6 != iVar12);
		          }
		        }
		        goto code_r0x82313dd9;
		      }
		code_r0x82313fb3:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x823143d3:
		      iVar11 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar11 == iVar6) {
		        piVar10 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_18 = *piVar10;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 != 1) {
		code_r0x8231441c:
		          DAT_ram_009d3e38 = 0;
		          piVar10 = *local_14;
		          if (piVar10 != (int *)0x0) {
		            uVar1 = 0;
		            iVar11 = *piVar10;
		            if (*(ushort *)(iVar11 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		                  puVar2 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x82314497;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		            }
		            puVar2 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x82314497:
		            (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		          }
		          if (local_18 == 0) {
		            return param1_00;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(local_18);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x25,&local_18);
		      goto joined_r0x823144e5;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x26,&local_18);
		joined_r0x823144e5:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006AFB")]
		[Address(RVA = "0xB603", Offset = "0xB603", VA = "0xB603")]
		public List<IInformationRow> GetMaterials()
		{
			return null;
		}

		// Token: 0x0400388B RID: 14475
		[Token(Token = "0x400388B")]
		public const string REQUIREMENTS_RESTRICTIONS = "REQUIREMENTS/RESTRICTIONS";

		// Token: 0x0400388C RID: 14476
		[Token(Token = "0x400388C")]
		public const string REQUIREMENTS_TARGET_RESTRICTIONS = "REQUIREMENTS/TARGET_RESTRICTIONS";

		// Token: 0x0400388D RID: 14477
		[Token(Token = "0x400388D")]
		public const string REQUIREMENTS_MATERIALS = "REQUIREMENTS/MATERIALS";

		// Token: 0x0400388E RID: 14478
		[Token(Token = "0x400388E")]
		[FieldOffset(Offset = "0x1C")]
		public IList<RestrictionInfo> RestrictionInfos;

		// Token: 0x0400388F RID: 14479
		[Token(Token = "0x400388F")]
		[FieldOffset(Offset = "0x20")]
		public IList<RewardInfo> Materials;

		// Token: 0x04003890 RID: 14480
		[Token(Token = "0x4003890")]
		[FieldOffset(Offset = "0x24")]
		public string RestrictionsTitle;

		// Token: 0x04003891 RID: 14481
		[Token(Token = "0x4003891")]
		[FieldOffset(Offset = "0x28")]
		public string MaterialsTitle;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CostProvider ---
		void Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__set_CostProvider
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  Core_Data_InfoRows_AbstractUserInformationProvider__set_User(param1,0);
		  return;
		}
		*/

}
