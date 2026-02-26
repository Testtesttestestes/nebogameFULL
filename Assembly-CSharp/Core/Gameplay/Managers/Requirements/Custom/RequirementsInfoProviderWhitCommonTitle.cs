using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Gameplay.Managers.Requirements.Custom
{
	// Token: 0x0200119D RID: 4509
	[Token(Token = "0x200119D")]
	public class RequirementsInfoProviderWhitCommonTitle : RequirementsInfoProvider
	{
		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006B23 RID: 27427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015DB")]
		public string Title
		{
			[Token(Token = "0x6006B24")]
			[Address(RVA = "0xB627", Offset = "0xB627", VA = "0xB627")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006B23")]
			[Address(RVA = "0xB626", Offset = "0xB626", VA = "0xB626")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B25")]
		[Address(RVA = "0xB628", Offset = "0xB628", VA = "0xB628")]
		public RequirementsInfoProviderWhitCommonTitle(UserData user, UserData loggedUser, IInformationProvider costProvider, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Requirements_Custom_RequirementsInfoProviderWhitCommonTitle___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int iVar6;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a64b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    DAT_ram_00a5a64b = '\x01';
		  }
		  iVar6 = param1[2];
		  param1_01 = (int *)param1[4];
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_InfoRows_IInformationRow___TypeInfo,1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,param1[0xc],*(undefined4 *)(*param1 + 0x104));
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    param1_00 = func_ii_1083();
		    func_ii_1050(param1_00,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = iVar3;
		  uVar1 = 0;
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x812497c3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,3);
		code_r0x812497c3:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,iVar6,piVar2,puVar5[1]);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Requirements_Custom_RequirementsInfoProviderWhitCommonTitle___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int iVar6;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a64b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    DAT_ram_00a5a64b = '\x01';
		  }
		  iVar6 = param1[2];
		  param1_01 = (int *)param1[4];
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_InfoRows_IInformationRow___TypeInfo,1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,param1[0xc],*(undefined4 *)(*param1 + 0x104));
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    param1_00 = func_ii_1083();
		    func_ii_1050(param1_00,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = iVar3;
		  uVar1 = 0;
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x812497c3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,3);
		code_r0x812497c3:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,iVar6,piVar2,puVar5[1]);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Requirements_Custom_RequirementsInfoProviderWhitCommonTitle___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int iVar6;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a64b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    DAT_ram_00a5a64b = '\x01';
		  }
		  iVar6 = param1[2];
		  param1_01 = (int *)param1[4];
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_InfoRows_IInformationRow___TypeInfo,1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,param1[0xc],*(undefined4 *)(*param1 + 0x104));
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    param1_00 = func_ii_1083();
		    func_ii_1050(param1_00,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = iVar3;
		  uVar1 = 0;
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x812497c3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,3);
		code_r0x812497c3:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,iVar6,piVar2,puVar5[1]);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B26")]
		[Address(RVA = "0xB629", Offset = "0xB629", VA = "0xB629")]
		public RequirementsInfoProviderWhitCommonTitle(UserData user, UserData loggedUser, IList<RestrictionInfo> restrictionInfos)
		{
		}

		// Token: 0x06006B27 RID: 27431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B27")]
		[Address(RVA = "0xB62A", Offset = "0xB62A", VA = "0xB62A")]
		public RequirementsInfoProviderWhitCommonTitle(UserData user, UserData loggedUser, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
		{
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B28")]
		[Address(RVA = "0xB62B", Offset = "0xB62B", VA = "0xB62B", Slot = "9")]
		protected override void PrepareInformation()
		{
		/* --- GHIDRA: PrepareInformation ---
		void Core_Gameplay_Managers_Requirements_Custom_RequirementsInfoProviderWhitCommonTitle__PrepareInformation
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a64c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a64c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Title ---
		void Core_Gameplay_Managers_Requirements_Custom_RequirementsInfoProviderWhitCommonTitle__get_Title
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a5a648 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_4519);
		    DAT_ram_00a5a648 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x30) = StringLiteral_4519;
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		            (param1,param2,param3,param4,param5,param6,0);
		  return;
		}
		*/

}
