using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Gameplay.Inventory.Model
{
	// Token: 0x0200069C RID: 1692
	[Token(Token = "0x200069C")]
	public class ArtifactInfoProvider : AbstractUserInformationProvider, IItemInformationProvider, IInformationProvider, IDisposable
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BE")]
		[CanBeNull]
		public ArtifactData Artifact
		{
			[Token(Token = "0x60028E2")]
			[Address(RVA = "0x79FB", Offset = "0x79FB", VA = "0x79FB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028E3")]
			[Address(RVA = "0x79FC", Offset = "0x79FC", VA = "0x79FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BF")]
		[NotNull]
		public ArtikulData Artikul
		{
			[Token(Token = "0x60028E4")]
			[Address(RVA = "0x79FD", Offset = "0x79FD", VA = "0x79FD", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028E5")]
			[Address(RVA = "0x79FE", Offset = "0x79FE", VA = "0x79FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x00007BA8 File Offset: 0x00005DA8
		// (set) Token: 0x060028E7 RID: 10471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C0")]
		public Color32 UserSkillValuesColor
		{
			[Token(Token = "0x60028E6")]
			[Address(RVA = "0x79FF", Offset = "0x79FF", VA = "0x79FF")]
			[CompilerGenerated]
			get
			{
				return default(Color32);
			}
			[Token(Token = "0x60028E7")]
			[Address(RVA = "0x7A00", Offset = "0x7A00", VA = "0x7A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x7A01", Offset = "0x7A01", VA = "0x7A01", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Inventory_Model_ArtifactInfoProvider__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  local_c = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_28 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_28,0);
		  *(undefined4 *)(param1 + 0x24) = local_4;
		  Core_Data_InfoRows_AbstractUserInformationProvider__Dispose(param1,param2,param3,0);
		  *(undefined4 *)(param1 + 0x20) = param4;
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  return;
		}
		*/

		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E9")]
		[Address(RVA = "0x7A02", Offset = "0x7A02", VA = "0x7A02")]
		public ArtifactInfoProvider(UserData user, UserData loggedUser, ArtifactData artifact)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Model_ArtifactInfoProvider___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5a12c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2634);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2635);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2636);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2628);
		    DAT_ram_00a5a12c = '\x01';
		  }
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_2628,1,0,1,0,0,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  uVar3 = Gameplay_Inventory_Model_ArtifactInfoProvider__HandleCollectionRow(param1,0);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtikulProps(param1,0);
		  uVar3 = Core_Data_InfoRows_AbstractInformationProvider___ctor(param1,uVar3,uVar4,0);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetCollectionRow(param1,0);
		  uVar3 = Core_Data_InfoRows_AbstractInformationProvider___ctor(param1,uVar3,uVar4,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x811d01fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x811d01fb:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar2,uVar3,puVar5[1]);
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  uVar2 = func_ii_7508(StringLiteral_2635,1,0,1,0,0,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  uVar3 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetSpellProps(param1,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x811d02c5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x811d02c5:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar2,uVar3,puVar5[1]);
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  uVar2 = func_ii_7508(StringLiteral_2634,1,0,1,0,0,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  uVar3 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetSpellDescription(param1,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x811d038f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x811d038f:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar2,uVar3,puVar5[1]);
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  uVar2 = func_ii_7508(StringLiteral_2636,1,0,1,0,0,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  uVar3 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetUserSkillsMods(param1,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x811d0459;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x811d0459:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar2,uVar3,puVar5[1]);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))(param1,*(undefined4 *)(*param1 + 0x11c));
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Model_ArtifactInfoProvider___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5a12c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2634);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2635);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2636);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2628);
		    DAT_ram_00a5a12c = '\x01';
		  }
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_2628,1,0,1,0,0,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  uVar3 = Gameplay_Inventory_Model_ArtifactInfoProvider__HandleCollectionRow(param1,0);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtikulProps(param1,0);
		  uVar3 = Core_Data_InfoRows_AbstractInformationProvider___ctor(param1,uVar3,uVar4,0);
		  uVar4 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetCollectionRow(param1,0);
		  uVar3 = Core_Data_InfoRows_AbstractInformationProvider___ctor(param1,uVar3,uVar4,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x811d01fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x811d01fb:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar2,uVar3,puVar5[1]);
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  uVar2 = func_ii_7508(StringLiteral_2635,1,0,1,0,0,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  uVar3 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetSpellProps(param1,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x811d02c5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x811d02c5:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar2,uVar3,puVar5[1]);
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  uVar2 = func_ii_7508(StringLiteral_2634,1,0,1,0,0,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  uVar3 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetSpellDescription(param1,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x811d038f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x811d038f:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar2,uVar3,puVar5[1]);
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  uVar2 = func_ii_7508(StringLiteral_2636,1,0,1,0,0,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,uVar2,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  uVar3 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetUserSkillsMods(param1,0);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x811d0459;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x811d0459:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar2,uVar3,puVar5[1]);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))(param1,*(undefined4 *)(*param1 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EA")]
		[Address(RVA = "0x7A03", Offset = "0x7A03", VA = "0x7A03")]
		public ArtifactInfoProvider(UserData user, UserData loggedUser, ArtikulData artikul)
		{
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x7A04", Offset = "0x7A04", VA = "0x7A04", Slot = "9")]
		protected override void PrepareInformation()
		{
		/* --- GHIDRA: PrepareInformation ---
		void Gameplay_Inventory_Model_ArtifactInfoProvider__PrepareInformation
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  uint *puVar7;
		  int iVar8;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a12d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2617);
		    DAT_ram_00a5a12d = '\x01';
		  }
		  iVar2 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactLifetimeDescriptionRow
		                    (param1,param1);
		  if (iVar2 != 0) {
		    iVar8 = param1[2];
		    param1_00 = (int *)param1[4];
		    piVar3 = (int *)Mono_Security_ASN1Convert__ToOid
		                              (Core_Data_InfoRows_IInformationRow___TypeInfo,2);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_2617,1,0,1,0,0,0,0);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,uVar4,*(undefined4 *)(*param1 + 0x104));
		    if ((iVar5 != 0) && (iVar6 = func_ii_1082(iVar5,*(undefined4 *)(*piVar3 + 0x20)), iVar6 == 0)) {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar3[4] = iVar5;
		    iVar5 = func_ii_1082(iVar2,*(undefined4 *)(*piVar3 + 0x20));
		    if (iVar5 == 0) {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar3[5] = iVar2;
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		          goto code_r0x811d1ef4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar7 = (uint *)func_ii_1080(param1_00,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,3);
		code_r0x811d1ef4:
		    (**(code **)((ulonglong)*puVar7 * 4))(param1_00,iVar8,piVar3,puVar7[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EC")]
		[Address(RVA = "0x7A05", Offset = "0x7A05", VA = "0x7A05", Slot = "11")]
		protected virtual void HandleCollectionRow()
		{
		/* --- GHIDRA: HandleCollectionRow ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__HandleCollectionRow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a12e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2630);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2631);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2637);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2629);
		    DAT_ram_00a5a12e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		  iVar2 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		  System_Collections_Generic_List_object____ctor(iVar2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2637,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar3;
		  uVar3 = func_ii_7568(*(undefined4 *)(*(int *)(param1 + 0x20) + 0xc),0);
		  *(undefined4 *)(iVar2 + 0x18) = uVar3;
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		  System_Collections_Generic_List_object____ctor(iVar2,0);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2631,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar3;
		  uVar3 = Core_Extensions_Dict_ItemQualityDicExt__GetMiddleBgSubstrateAssetId
		                    (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x14),0);
		  *(undefined4 *)(iVar2 + 0x1c) = 0;
		  *(undefined4 *)(iVar2 + 0x18) = uVar3;
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x20) + 0x14) + 0x18);
		  if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Convert_TypeInfo);
		  }
		  uVar3 = System_Convert__ToUInt16(uVar3,0x10,0);
		  Utils_BaseMonoBehaviour___ctor(iVar2 + 0x1c,uVar3,0);
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = Core_Data_ArtikulData__set_TargetRequirements(*(undefined4 *)(param1 + 0x20),0);
		  if (iVar2 != 0) {
		    iVar2 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(iVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2629,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0xc) = uVar3;
		    uVar3 = func_ii_7508(StringLiteral_2630,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x18) = uVar3;
		    iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		      return param1_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028ED")]
		[Address(RVA = "0x7A06", Offset = "0x7A06", VA = "0x7A06")]
		public List<IInformationRow> GetArtikulProps()
		{
		/* --- GHIDRA: GetArtikulProps ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtikulProps
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  uint uVar3;
		  uint uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a12f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    DAT_ram_00a5a12f = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		  iVar2 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactProps(param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  if (iVar2 != 0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar2 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactRepairableRow(param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  if (iVar2 != 0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar2 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactDurabilityRow(param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  if (iVar2 != 0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar2 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactLevelRow(param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  if (iVar2 != 0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar2 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactSellableRow(param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  if (iVar2 != 0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar2 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactLifetimeRow(param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  if (iVar2 != 0) {
		    iVar5 = *(int *)(param1_00 + 0x10) + 1;
		    *(int *)(param1_00 + 0x10) = iVar5;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      uVar3 = uVar4 + 1;
		      *(uint *)(param1_00 + 0xc) = uVar3;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      uVar3 = *(uint *)(param1_00 + 0xc);
		      iVar5 = *(int *)(param1_00 + 0x10);
		    }
		    iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		    *(int *)(param1_00 + 0x10) = iVar5 + 1;
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = iVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar2 = Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactPriceRow(param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		  if (iVar2 != 0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		      return param1_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028EE")]
		[Address(RVA = "0x7A07", Offset = "0x7A07", VA = "0x7A07")]
		public List<IInformationRow> GetArtifactProps()
		{
		/* --- GHIDRA: GetArtifactProps ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactProps(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  uint uVar2;
		  int iVar3;
		  double dVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  int iVar7;
		  ushort local_a;
		  float8 local_8;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a5a130 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2621);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2623);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a130 = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    dVar4 = func_ii_7527(*(undefined4 *)
		                          (*(int *)(*(int *)(*(int *)(param1 + 0x1c) + 0x74) + 0x20) + 0xc),2,
		                         Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    puVar5 = &StringLiteral_2623;
		    iVar7 = *(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x1c) + 8) + 0x10) + 0x20);
		    if (iVar7 != 0xb) {
		      puVar5 = &StringLiteral_2621;
		    }
		    uVar6 = *puVar5;
		    local_8 = (float8)dVar4;
		    if (iVar7 == 0xb) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar2 = 0;
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *param1_00;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x140);
		            goto code_r0x811d1499;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		      }
		      puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811d1499:
		      iVar7 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		      uVar2 = *(uint *)(*(int *)(*(int *)(iVar7 + 0x14) + 0x20) + 0x10);
		    }
		    else {
		      uVar2 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0xc),0);
		    }
		    iVar7 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(iVar7,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar6,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar7 + 0xc) = uVar6;
		    iVar3 = func_ii_7515(&local_8,0);
		    if (iVar3 == 0) {
		      iVar3 = StringLiteral_5;
		    }
		    *(int *)(iVar7 + 0x18) = iVar3;
		    local_a = 0;
		    System_Data_SqlTypes_SqlByte__ToSqlInt64
		              (&local_a,(uint)(dVar4 <= (double)uVar2),Method_System_Nullable_bool___ctor__);
		    *(ushort *)(iVar7 + 0x10) = local_a;
		  }
		  return iVar7;
		}
		*/

			return null;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x7A08", Offset = "0x7A08", VA = "0x7A08")]
		public IInformationRow GetArtifactLevelRow()
		{
		/* --- GHIDRA: GetArtifactLevelRow ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactLevelRow(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a5a131 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2633);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2625);
		    DAT_ram_00a5a131 = '\x01';
		  }
		  iVar1 = Core_Data_ArtikulData__get_ShowDismantleAlert(*(undefined4 *)(param1 + 0x20),0);
		  if (iVar1 == 0) {
		    param1_00 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(param1_00,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2633,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0xc) = uVar2;
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2625,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x7A09", Offset = "0x7A09", VA = "0x7A09")]
		public IInformationRow GetArtifactSellableRow()
		{
		/* --- GHIDRA: GetArtifactSellableRow ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactSellableRow
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a5a132 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2632);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2624);
		    DAT_ram_00a5a132 = '\x01';
		  }
		  iVar1 = Core_Data_ArtikulData__get_IsGolemItem(*(undefined4 *)(param1 + 0x20),0);
		  if (iVar1 == 0) {
		    param1_00 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(param1_00,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2632,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0xc) = uVar2;
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2624,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x7A0A", Offset = "0x7A0A", VA = "0x7A0A")]
		public IInformationRow GetArtifactRepairableRow()
		{
		/* --- GHIDRA: GetArtifactRepairableRow ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactRepairableRow
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  int iVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a133 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2619);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2620);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2616);
		    DAT_ram_00a5a133 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_uint__uint___TryGetValue
		                    (*(undefined4 *)(param1 + 0x20),0);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById
		                      (*(undefined4 *)(param1 + 0x20),0);
		    if (iVar1 == 0) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2619,1,0,1,0,0,0,0);
		      iVar1 = **(int **)(param1 + 0x20);
		      local_8 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                          (*(int **)(param1 + 0x20),*(undefined4 *)(iVar1 + 0xec));
		    }
		    else {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2616,1,0,1,0,0,0,0);
		      iVar1 = **(int **)(param1 + 0x20);
		      local_8 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                          (*(int **)(param1 + 0x20),*(undefined4 *)(iVar1 + 0xf4));
		    }
		    if (local_8 == 0) {
		      return 0;
		    }
		    iVar1 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(iVar1,0);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		    iVar5 = **(int **)(param1 + 0x20);
		    local_4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf8) * 4))
		                        (*(int **)(param1 + 0x20),*(undefined4 *)(iVar5 + 0xfc));
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    param3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28672,uVar2,param3,0);
		    *(undefined4 *)(iVar1 + 0x18) = uVar2;
		    iVar5 = **(int **)(param1 + 0x20);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf8) * 4))
		                      (*(int **)(param1 + 0x20),*(undefined4 *)(iVar5 + 0xfc));
		    iVar3 = Core_Data_ArtikulData__get_MaxDurability(*(undefined4 *)(param1 + 0x20),0);
		    if (iVar5 < iVar3) {
		      if (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		      }
		      puVar4 = (undefined4 *)
		               (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x5c) + 4);
		    }
		    else {
		      if (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		      }
		      puVar4 = *(undefined4 **)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x5c);
		    }
		  }
		  else {
		    iVar1 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(iVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2619,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2620,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar1 + 0x18) = uVar2;
		    if (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x5c);
		  }
		  *(undefined4 *)(iVar1 + 0x1c) = *puVar4;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x7A0B", Offset = "0x7A0B", VA = "0x7A0B")]
		public IInformationRow GetArtifactDurabilityRow()
		{
		/* --- GHIDRA: GetArtifactDurabilityRow ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactDurabilityRow
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  undefined4 uVar2;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a5a134 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2626);
		    DAT_ram_00a5a134 = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    param1_01 = Core_Data_ArtifactData__get_IsTemporaryWithExpiredLifetime
		                          (*(int *)(param1 + 0x1c),0);
		    iVar1 = Core_Extensions_Dict_ResourceSetExt__GetDelta(param1_01,0);
		    if (iVar1 == 0) {
		      param1_00 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		      System_Collections_Generic_List_object____ctor(param1_00,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2626,1,0,1,0,0,0,0);
		      *(undefined4 *)(param1_00 + 0x20) = param1_01;
		      *(undefined4 *)(param1_00 + 0xc) = uVar2;
		      *(undefined4 *)(param1_00 + 0x30) = *(undefined4 *)(param1 + 0xc);
		    }
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x7A0C", Offset = "0x7A0C", VA = "0x7A0C")]
		public IInformationRow GetArtifactPriceRow()
		{
		/* --- GHIDRA: GetArtifactPriceRow ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactPriceRow(int param1,undefined4 param2)
		
		{
		  ulonglong uVar1;
		  int param1_00;
		  int iVar2;
		  float fVar3;
		  undefined4 uVar4;
		  longlong lVar5;
		  longlong lVar6;
		  ulonglong local_10;
		  longlong local_8;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a5a135 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_BackTimeRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9120);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2622);
		    DAT_ram_00a5a135 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = Core_Data_ArtikulData__get_MinDurability(*(undefined4 *)(param1 + 0x20),0);
		  if (iVar2 != 0) {
		    if (*(int *)(param1 + 0x1c) == 0) {
		      param1_00 = 0;
		      iVar2 = Core_Data_ArtikulData__TryGetLifeDurationSec
		                        (*(undefined4 *)(param1 + 0x20),&local_8,0);
		      lVar6 = local_8;
		      if (iVar2 == 0) {
		        iVar2 = Core_Data_ArtikulData__get_IsTemporary(*(undefined4 *)(param1 + 0x20),&local_10,0);
		        if (iVar2 != 0) {
		          param1_00 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		          System_Collections_Generic_List_object____ctor(param1_00,0);
		          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_GameLocalization_TypeInfo);
		          }
		          uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9120,1,0,1,0,0,0,0);
		          uVar1 = local_10;
		          *(undefined4 *)(param1_00 + 0xc) = uVar4;
		          if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Utils_TimeUtils_TypeInfo);
		          }
		          uVar4 = Utils_TimeUtils__DateFormat((double)uVar1,0);
		          *(undefined4 *)(param1_00 + 0x18) = uVar4;
		        }
		      }
		      else {
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        lVar5 = Utils_TimeUtils__Format(0);
		        uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		        lVar6 = lVar6 - lVar5;
		        if (lVar6 < 1) {
		          lVar6 = 0;
		        }
		        Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,(float)lVar6,0);
		        param1_00 = unnamed_function_1417(Core_Data_InfoRows_BackTimeRow_TypeInfo);
		        Core_Data_InfoRows_CommonRow___ctor(param1_00,uVar4,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2622,1,0,1,0,0,0,0);
		        *(undefined4 *)(param1_00 + 0xc) = uVar4;
		      }
		    }
		    else {
		      uVar4 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x88);
		      param1_00 = unnamed_function_1417(Core_Data_InfoRows_BackTimeRow_TypeInfo);
		      Core_Data_InfoRows_CommonRow___ctor(param1_00,uVar4,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2622,1,0,1,0,0,0,0);
		      *(undefined4 *)(param1_00 + 0xc) = uVar4;
		      fVar3 = func_ii_7103(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x88),0);
		      if (0.0 < fVar3) {
		        iVar2 = *(int *)(*(int *)(param1 + 0x1c) + 0x34);
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        fVar3 = func_ii_7331((longlong)iVar2,0);
		      }
		      else {
		        fVar3 = 3.4028235e+38;
		      }
		      *(float *)(param1_00 + 0x14) = fVar3;
		      iVar2 = Core_Data_ArtifactData__get_Rank(*(undefined4 *)(param1 + 0x1c),0);
		      if (iVar2 != 0) {
		        fVar3 = func_ii_7103(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x88),0);
		        *(float *)(param1_00 + 0x14) = fVar3;
		      }
		    }
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x7A0D", Offset = "0x7A0D", VA = "0x7A0D")]
		public IInformationRow GetArtifactLifetimeRow()
		{
		/* --- GHIDRA: GetArtifactLifetimeRow ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactLifetimeRow
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a5a136 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_DescriptionRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13154);
		    DAT_ram_00a5a136 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x1c) != 0) &&
		     (iVar1 = Core_Data_ArtifactData__get_Rank(*(int *)(param1 + 0x1c),0), iVar1 != 0)) {
		    param1_00 = unnamed_function_1417(Core_Data_InfoRows_DescriptionRow_TypeInfo);
		    Core_Data_InfoRows_BackTimeRow___ctor(param1_00,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_13154,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0xc) = uVar2;
		    if (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    }
		    *(undefined4 *)(param1_00 + 0x10) =
		         *(undefined4 *)
		          (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x5c) + 4);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x7A0E", Offset = "0x7A0E", VA = "0x7A0E")]
		public IInformationRow GetArtifactLifetimeDescriptionRow()
		{
		/* --- GHIDRA: GetArtifactLifetimeDescriptionRow ---
		uint Gameplay_Inventory_Model_ArtifactInfoProvider__GetArtifactLifetimeDescriptionRow
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param3;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a137 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Id__);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_CollectionRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_ICollectionsMaterialsStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2618);
		    DAT_ram_00a5a137 = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(*(int *)(*(int *)(param1 + 0x20) + 8) + 0x10) != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x280);
		          goto code_r0x811d2024;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x811d2024:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    uVar5 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x20) + 8) + 0xc);
		    piVar3 = *(int **)(iVar4 + 0x20);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Collections_Model_ICollectionsMaterialsStorage_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811d20b6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  Gameplay_Collections_Model_ICollectionsMaterialsStorage_TypeInfo,0
		                                 );
		code_r0x811d20b6:
		    uVar1 = 0;
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,uVar5,&local_4,puVar2[1]);
		    uVar5 = local_4;
		    if (iVar4 != 0) {
		      param3 = *(undefined4 *)(param1 + 0xc);
		      uVar1 = unnamed_function_1417(Core_Data_InfoRows_CollectionRow_TypeInfo);
		      Core_Data_InfoRows_ModifierRow__Create(uVar1,uVar5,param3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2618,1,0,1,0,0,0,0);
		      *(undefined4 *)(uVar1 + 0xc) = uVar5;
		    }
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x7A0F", Offset = "0x7A0F", VA = "0x7A0F")]
		public IInformationRow GetCollectionRow()
		{
		/* --- GHIDRA: GetCollectionRow ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetCollectionRow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  longlong lVar4;
		  undefined8 uVar5;
		  int iVar6;
		  uint uVar7;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5a138 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2627);
		    DAT_ram_00a5a138 = '\x01';
		  }
		  iVar6 = *(int *)(*(int *)(param1 + 0x20) + 0x18);
		  if (iVar6 != 0) {
		    uVar2 = func_ii_10810(iVar6,0);
		    iVar3 = Core_Extensions_Dict_ResourceSetExt__GetDelta(uVar2,0);
		    if ((iVar3 != 0) &&
		       (lVar4 = Core_Data_Spells_SpellData__get_Level
		                          (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x18),0), lVar4 < 1)) {
		      return 0;
		    }
		    iVar3 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar3,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    iVar6 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(iVar6,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2627,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar6 + 0xc) = uVar2;
		    uVar2 = func_ii_10810(*(undefined4 *)(*(int *)(param1 + 0x20) + 0x18),0);
		    *(undefined4 *)(iVar6 + 0x20) = uVar2;
		    uVar5 = Core_Data_Spells_SpellData__get_Level(*(undefined4 *)(*(int *)(param1 + 0x20) + 0x18),0)
		    ;
		    *(undefined8 *)(iVar6 + 0x28) = uVar5;
		    *(undefined4 *)(iVar6 + 0x30) = *(undefined4 *)(param1 + 0xc);
		    iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    uVar7 = *(uint *)(iVar3 + 0xc);
		    if (uVar7 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		      *(uint *)(iVar3 + 0xc) = uVar7 + 1;
		      *(int *)(*(int *)(iVar3 + 8) + uVar7 * 4 + 0x10) = iVar6;
		      return iVar3;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return iVar3;
		}
		*/

			return null;
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x7A10", Offset = "0x7A10", VA = "0x7A10")]
		public List<IInformationRow> GetSpellProps()
		{
		/* --- GHIDRA: GetSpellProps ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetSpellProps(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int param1_01;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a5a139 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_DescriptionRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    DAT_ram_00a5a139 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x20) + 0x18) != 0) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    param1_01 = unnamed_function_1417(Core_Data_InfoRows_DescriptionRow_TypeInfo);
		    Core_Data_InfoRows_BackTimeRow___ctor(param1_01,0);
		    uVar2 = Core_Data_ArtikulData__get_Title(*(undefined4 *)(param1 + 0x20),0);
		    uVar2 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar2,0);
		    *(undefined4 *)(param1_01 + 0xc) = uVar2;
		    iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param1_01;
		      return param1_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x7A11", Offset = "0x7A11", VA = "0x7A11")]
		public List<IInformationRow> GetSpellDescription()
		{
		/* --- GHIDRA: GetSpellDescription ---
		undefined4
		Gameplay_Inventory_Model_ArtifactInfoProvider__GetSpellDescription(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  uint uVar7;
		  int iVar8;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5a13a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    DAT_ram_00a5a13a = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) == 0) {
		    return 0;
		  }
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x50),
		                     Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar1,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  while( true ) {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		                        );
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d115c;
		      }
		      iVar8 = local_20;
		      if (iVar2 == 0) goto code_r0x811d11a5;
		      DAT_ram_009d3e38 = 0;
		      iVar2 = local_8._4_4_;
		      iVar3 = func_ii_7588(local_8._4_4_,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811d115c;
		      }
		    } while (iVar3 != 0);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33,
		                       *(undefined4 *)(param1 + 0x14),*(undefined4 *)(iVar2 + 8),0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) break;
		    if (iVar4 == 0) {
		      uVar5 = *(undefined4 *)
		               (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x1c) + 0x74) + 0x20) + 0x10) + 0xc);
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_List_IInformationRow__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x25a,iVar4,uVar5,
		                   Method_System_Collections_Generic_List_IInformationRow___ctor__);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x811d0f60;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d115c;
		    }
		code_r0x811d0f60:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Core_Data_InfoRows_ValueRow_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811d110e:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d115c;
		    }
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_List_object____ctor(iVar8,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811d110e;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x33,uVar1,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d115c;
		    }
		    *(undefined4 *)(iVar8 + 0xc) = uVar5;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x259,iVar2,0)
		    ;
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d115c;
		    }
		    *(undefined4 *)(iVar8 + 0x18) = uVar5;
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x34,uVar1,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811d115c;
		    }
		    *(undefined4 *)(iVar8 + 0x14) = uVar1;
		    *(undefined4 *)(iVar8 + 0x1c) = *(undefined4 *)(param1 + 0x24);
		    iVar2 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar7 = *(uint *)(iVar4 + 0xc);
		    if (uVar7 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar7 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar7 * 4 + 0x10) = iVar8;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar8,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811d115c:
		        iVar8 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar8 == iVar2) {
		          piVar6 = (int *)import::env::__cxa_begin_catch(uVar1);
		          iVar8 = *piVar6;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar8;
		          import::env::invoke_v(0x123);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		code_r0x811d11a5:
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 == 0) {
		              DAT_ram_009d3e38 = 0;
		              return iVar4;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar1 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x25c,&local_20);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          import::env::__resumeException(uVar1);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x811d115c;
		}
		*/

			return null;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x7A12", Offset = "0x7A12", VA = "0x7A12")]
		public List<IInformationRow> GetUserSkills()
		{
		/* --- GHIDRA: GetUserSkills ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetUserSkills(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  uint uVar7;
		  int param2_00;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar2 = 0;
		  param2_00 = 0;
		  if (DAT_ram_00a5a13b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_int__Skill__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_int__Skill__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_int__Skill__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_int__Skill__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    DAT_ram_00a5a13b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  if (*(int *)(param1 + 0x1c) != 0) {
		    param1_00 = Core_Data_ArtifactData__get_SpellsModifierData(*(int *)(param1 + 0x1c),0);
		    iVar6 = *(int *)(param1_00 + 0xc);
		    if (0 < iVar6) {
		      do {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (param1_00,param2_00,
		                           Method_System_Collections_Generic_List_ModifierData__get_Item__);
		        System_Collections_Generic_List_object___GetEnumerator
		                  (&local_30,*(undefined4 *)(iVar1 + 0x10),
		                   Method_System_Collections_Generic_Dictionary_int__Skill__GetEnumerator__);
		        local_8 = local_20;
		        local_10 = local_28;
		        local_18 = CONCAT44(puStack_2c,local_30);
		        local_30 = 0;
		        puStack_2c = &local_18;
		code_r0x811d225b:
		        do {
		          do {
		            do {
		              DAT_ram_009d3e38 = 0;
		              iVar1 = import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x20e,&local_18,
		                                 Method_System_Collections_Generic_Dictionary_Enumerator_int__Skill__MoveNext__
		                                );
		              if (DAT_ram_009d3e38 == 1) goto code_r0x811d254c;
		              iVar4 = local_30;
		              if (iVar1 == 0) goto code_r0x811d259c;
		              iVar1 = (int)local_8;
		            } while (*(longlong *)((int)local_8 + 0x10) < 1);
		            DAT_ram_009d3e38 = 0;
		            iVar4 = func_ii_8544((int)local_8,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x811d254c;
		          } while (iVar4 == 0);
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            iVar2 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_Collections_Generic_List_IInformationRow__TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,iVar2,
		                         Method_System_Collections_Generic_List_IInformationRow___ctor__);
		              if (DAT_ram_009d3e38 != 1) goto code_r0x811d2349;
		            }
		            iVar2 = 0;
		            break;
		          }
		code_r0x811d2349:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33,
		                             *(undefined4 *)(param1 + 0x14),*(int *)(iVar1 + 8) + 1,0);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             Core_Data_InfoRows_ValueRow_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          System_Collections_Generic_List_object____ctor(iVar4,0);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x33,uVar3,0);
		          if (DAT_ram_009d3e38 == 1) break;
		          *(undefined4 *)(iVar4 + 0xc) = uVar3;
		          DAT_ram_009d3e38 = 0;
		          uVar3 = unnamed_function_184057
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x25e,
		                             *(undefined8 *)(iVar1 + 0x10),0);
		          if (DAT_ram_009d3e38 == 1) break;
		          *(undefined4 *)(iVar4 + 0x18) = uVar3;
		          if (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		          }
		          *(undefined4 *)(iVar4 + 0x1c) =
		               **(undefined4 **)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x5c);
		          iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		          *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		          uVar7 = *(uint *)(iVar2 + 0xc);
		          if (uVar7 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		            *(uint *)(iVar2 + 0xc) = uVar7 + 1;
		            *(int *)(*(int *)(iVar2 + 8) + uVar7 * 4 + 0x10) = iVar4;
		            goto code_r0x811d225b;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar4,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        } while (DAT_ram_009d3e38 != 1);
		code_r0x811d254c:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		        iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 != iVar4) {
		code_r0x811d25cd:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x25f,&local_30);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__resumeException(uVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x811d25cd;
		        }
		code_r0x811d259c:
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param2_00 = param2_00 + 1;
		      } while (param2_00 != iVar6);
		    }
		  }
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x7A13", Offset = "0x7A13", VA = "0x7A13")]
		public List<IInformationRow> GetUserSkillsMods()
		{
		/* --- GHIDRA: GetUserSkillsMods ---
		int Gameplay_Inventory_Model_ArtifactInfoProvider__GetUserSkillsMods(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int param2_00;
		  int param1_01;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 param1_02;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a5a13c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    DAT_ram_00a5a13c = '\x01';
		  }
		  if ((*(int *)(param1 + 0x1c) != 0) &&
		     (param1_01 = Core_Data_ArtifactData__get_ModifierData(*(int *)(param1 + 0x1c),0),
		     0 < *(int *)(param1_01 + 0xc))) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    iVar4 = *(int *)(param1_01 + 0xc);
		    if (0 < iVar4) {
		      param2_00 = 0;
		      do {
		        uVar2 = System_Linq_Enumerable__ToList_object_
		                          (param1_01,param2_00,
		                           Method_System_Collections_Generic_List_ModifierData__get_Item__);
		        param1_02 = *(undefined4 *)(param1 + 0x14);
		        uVar3 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(uVar2,0);
		        uVar3 = Core_Extensions_Dict_DictExt__GetItemQuality(param1_02,uVar3,0);
		        uVar2 = Core_Data_InfoRows_ModifierRow___ctor(uVar2,uVar3,0,0,0,0);
		        iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar5 = *(uint *)(param1_00 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		          *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar2;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		        param2_00 = param2_00 + 1;
		      } while (param2_00 != iVar4);
		    }
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x7A14", Offset = "0x7A14", VA = "0x7A14")]
		public List<IInformationRow> GetSpellMods()
		{
		/* --- GHIDRA: GetSpellMods ---
		void Gameplay_Inventory_Model_ArtifactInfoProvider__GetSpellMods(undefined4 param1)
		
		{
		  if (DAT_ram_00a5a13d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    DAT_ram_00a5a13d = '\x01';
		  }
		  **(undefined4 **)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x5c) = 0xff4ecb49;
		  *(undefined4 *)(*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x5c) + 4) =
		       0xff1111fe;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04001693 RID: 5779
		[Token(Token = "0x4001693")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 GREEN_COLOR;

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		[FieldOffset(Offset = "0x4")]
		public static Color32 RED_COLOR;

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		public const string ARTIFACT_PROPERTIES = "ARTIFACT/PROPERTIES";

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		public const string ARTIFACT_SKILLS = "ARTIFACT/SKILLS";

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		public const string ARTIFACT_SKILLS_MODS = "ARTIFACT/SKILLS_MODS";

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		public const string ARTIFACT_SPELL_MODS = "ARTIFACT/SPELL_MODS";

		// Token: 0x04001699 RID: 5785
		[Token(Token = "0x4001699")]
		public const string ARTIFACT_TYPE = "ARTIFACT/TYPE";

		// Token: 0x0400169A RID: 5786
		[Token(Token = "0x400169A")]
		public const string ARTIFACT_QUALITY = "ARTIFACT/QUALITY";

		// Token: 0x0400169B RID: 5787
		[Token(Token = "0x400169B")]
		public const string ARTIFACT_LEVEL = "ARTIFACT/LEVEL";

		// Token: 0x0400169C RID: 5788
		[Token(Token = "0x400169C")]
		public const string ARTIFACT_MASTERY = "ARTIFACT/MASTERY";

		// Token: 0x0400169D RID: 5789
		[Token(Token = "0x400169D")]
		public const string ARTIFACT_CHARGES = "ARTIFACT/CHARGES";

		// Token: 0x0400169E RID: 5790
		[Token(Token = "0x400169E")]
		public const string ARTIFACT_DURAB = "ARTIFACT/DURAB";

		// Token: 0x0400169F RID: 5791
		[Token(Token = "0x400169F")]
		public const string ARTIFACT_PRICE = "ARTIFACT/PRICE";

		// Token: 0x040016A0 RID: 5792
		[Token(Token = "0x40016A0")]
		public const string ARTIFACT_LIFETIME = "ARTIFACT/LIFETIME";

		// Token: 0x040016A1 RID: 5793
		[Token(Token = "0x40016A1")]
		public const string ARTIFACT_PRICE_OF_USE = "ARTIFACT/PRICE_OF_USE";

		// Token: 0x040016A2 RID: 5794
		[Token(Token = "0x40016A2")]
		public const string RESTORE_ITEM_HINT_DESC = "RESTORE_ITEM_HINT_DESC";

		// Token: 0x040016A3 RID: 5795
		[Token(Token = "0x40016A3")]
		public const string ARTIFACT_SPELL_DESCRIPTION = "ARTIFACT/SPELL/DESCRIPTION";

		// Token: 0x040016A4 RID: 5796
		[Token(Token = "0x40016A4")]
		public const string ARTIFACT_INDESTRUCTIBLE_VALUE = "ARTIFACT/INDESTRUCTIBLE";

		// Token: 0x040016A5 RID: 5797
		[Token(Token = "0x40016A5")]
		public const string ARTIFACT_SALE_STATUS = "ARTIFACT/SALE_STATUS";

		// Token: 0x040016A6 RID: 5798
		[Token(Token = "0x40016A6")]
		public const string ARTIFACT_NOT_SALE_STATUS_VALUE = "ARTIFACT/NOT_SALE_STATUS";

		// Token: 0x040016A7 RID: 5799
		[Token(Token = "0x40016A7")]
		public const string ARTIFACT_REPAIR_STATUS = "ARTIFACT/REPAIR_STATUS";

		// Token: 0x040016A8 RID: 5800
		[Token(Token = "0x40016A8")]
		public const string ARTIFACT_NOT_REPAIR_STATUS_VALUE = "ARTIFACT/NOT_REPAIR_STATUS";

		// Token: 0x040016A9 RID: 5801
		[Token(Token = "0x40016A9")]
		public const string ARTIFACT_PROPS = "ARTIFACT/PROPS";

		// Token: 0x040016AA RID: 5802
		[Token(Token = "0x40016AA")]
		public const string ARTIFACT_PROPS_VALUE = "ARTIFACT/PROPS_CLASS";

		// Token: 0x040016AB RID: 5803
		[Token(Token = "0x40016AB")]
		public const string ARTIFACT_COLLECTION = "ARTIFACT/COLLECTION";

		// Token: 0x040016AC RID: 5804
		[Token(Token = "0x40016AC")]
		public const string ARTIFACT_COLLECTION_ANNOTATION = "ARTIFACT/COLLECTION_ANNOTATION";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Artikul ---
		void Gameplay_Inventory_Model_ArtifactInfoProvider__set_Artikul
		               (undefined4 *param1,int param2,undefined4 param3)
		
		{
		  *param1 = *(undefined4 *)(param2 + 0x24);
		  return;
		}
		*/


		/* --- GHIDRA: get_UserSkillValuesColor ---
		void Gameplay_Inventory_Model_ArtifactInfoProvider__get_UserSkillValuesColor
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x24) = *param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_UserSkillValuesColor ---
		void Gameplay_Inventory_Model_ArtifactInfoProvider__set_UserSkillValuesColor
		               (int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  Core_Data_InfoRows_AbstractUserInformationProvider__set_User(param1,0);
		  return;
		}
		*/

}
