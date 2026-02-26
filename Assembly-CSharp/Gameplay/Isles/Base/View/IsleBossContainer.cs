using System;
using CloudsFly;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.WorldView;
using Gameplay.Isles.Base.Events;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.Base.View
{
	// Token: 0x02000CFC RID: 3324
	[Token(Token = "0x2000CFC")]
	public class IsleBossContainer : BaseWorldObjectRenderer
	{
		// Token: 0x06005112 RID: 20754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005112")]
		[Address(RVA = "0x9F02", Offset = "0x9F02", VA = "0x9F02")]
		public void Init(IIsle isle, BaseIsleEvents isleEvents)
		{
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005113")]
		[Address(RVA = "0x9F03", Offset = "0x9F03", VA = "0x9F03")]
		private void CurrentCreateRequestChangedEvent()
		{
		/* --- GHIDRA: CurrentCreateRequestChangedEvent ---
		void Gameplay_Isles_Base_View_IsleBossContainer__CurrentCreateRequestChangedEvent
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  Gameplay_Isles_Base_View_IsleBossContainer__IsCurrentChangedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005114 RID: 20756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005114")]
		[Address(RVA = "0x9F04", Offset = "0x9F04", VA = "0x9F04")]
		private void CurrentBossInstanceChangedEvent(long obj)
		{
		/* --- GHIDRA: CurrentBossInstanceChangedEvent ---
		void Gameplay_Isles_Base_View_IsleBossContainer__CurrentBossInstanceChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Isles_Base_View_IsleBossContainer__IsCurrentChangedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005115")]
		[Address(RVA = "0x9F05", Offset = "0x9F05", VA = "0x9F05")]
		private void IsCurrentChangedEvent()
		{
		/* --- GHIDRA: IsCurrentChangedEvent ---
		void Gameplay_Isles_Base_View_IsleBossContainer__IsCurrentChangedEvent(int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  uint *puVar2;
		  int *piVar3;
		  int param1_00;
		  int iVar4;
		  int iVar5;
		  longlong lVar6;
		  int iVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a58ce5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Base_IIsle_TypeInfo);
		    DAT_ram_00a58ce5 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x34);
		  if (piVar3 != (int *)0x0) {
		    uVar8 = 0;
		    iVar7 = *piVar3;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xd8);
		          goto code_r0x80f9b0bb;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Isles_Base_IIsle_TypeInfo,3);
		code_r0x80f9b0bb:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar7 == 0) {
		      uVar8 = 0;
		      piVar3 = *(int **)(param1 + 0x34);
		      iVar7 = *piVar3;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 200);
		            goto code_r0x80f9b13c;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Isles_Base_IIsle_TypeInfo,1);
		code_r0x80f9b13c:
		      iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      if (iVar7 != 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar7 = *piVar3;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar8 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0x1e0
		                               );
		              goto code_r0x80f9b1e9;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80f9b1e9:
		        iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		        param1_00 = *(int *)(iVar7 + 0x18);
		        iVar7 = Gameplay_Boss_Model_BossModel__GetBoss(param1_00,0);
		        if (iVar7 != 0) {
		          iVar4 = *(int *)(*(int *)(*(int *)(*(int *)(iVar7 + 8) + 0x28) + 0x20) + 0xc);
		          piVar3 = *(int **)(param1 + 0x34);
		          iVar5 = *piVar3;
		          if (*(ushort *)(iVar5 + 0xb6) != 0) {
		            uVar8 = 0;
		            do {
		              if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)
		                 ) {
		                puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 +
		                                 0xe0);
		                goto code_r0x80f9b28e;
		              }
		              uVar8 = uVar8 + 1;
		            } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Isles_Base_IIsle_TypeInfo,4);
		code_r0x80f9b28e:
		          iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		          if (iVar5 == iVar4) {
		            uVar8 = 0;
		            lVar6 = *(longlong *)(*(int *)(*(int *)(*(int *)(iVar7 + 8) + 0x28) + 0x20) + 0x10);
		            piVar3 = *(int **)(param1 + 0x34);
		            iVar4 = *piVar3;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (Gameplay_Isles_Base_IIsle_TypeInfo ==
		                    *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8)) {
		                  puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80f9b326;
		                }
		                uVar8 = uVar8 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		            }
		            puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Isles_Base_IIsle_TypeInfo,0);
		code_r0x80f9b326:
		            lVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		            if (lVar1 == lVar6) {
		              Gameplay_Isles_Base_View_IsleBossContainer__Clear(param1,iVar7,puVar2);
		              return;
		            }
		          }
		        }
		        iVar7 = *(int *)(param1_00 + 0x20);
		        if (iVar7 != 0) {
		          Gameplay_Isles_Base_View_IsleBossContainer__ShowBoss(param1,iVar7,iVar7);
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005116 RID: 20758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005116")]
		[Address(RVA = "0x9F06", Offset = "0x9F06", VA = "0x9F06")]
		private void ValidateBoss()
		{
		/* --- GHIDRA: ValidateBoss ---
		void Gameplay_Isles_Base_View_IsleBossContainer__ValidateBoss(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a58ce6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Base_View_IsleBossContainer_CurrentBossInstanceChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Base_View_IsleBossContainer_CurrentCreateRequestChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Base_View_IsleBossContainer_IsCurrentChangedEvent__);
		    DAT_ram_00a58ce6 = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x38);
		  if (iVar5 != 0) {
		    uVar8 = *(undefined4 *)(iVar5 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_Base_View_IsleBossContainer_IsCurrentChangedEvent__,0);
		    piVar6 = (int *)func_ii_7048(uVar8,uVar3,0);
		    iVar7 = System_Action_TypeInfo;
		    if (piVar6 == (int *)0x0) {
		      *(undefined4 *)(iVar5 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar6) ||
		            (*(int **)(iVar5 + 0x18) = piVar6, *piVar6 != iVar7)) {
		      System_Activator__CreateInstance(piVar6,iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1e0);
		        goto code_r0x80f9b6ed;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80f9b6ed:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar7 = *(int *)(iVar5 + 0x14);
		  uVar8 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_long__TypeInfo);
		  System_Action_Int32Enum___Invoke
		            (uVar3,param1,
		             Method_Gameplay_Isles_Base_View_IsleBossContainer_CurrentBossInstanceChangedEvent__,0);
		  iVar5 = func_ii_7048(uVar8,uVar3,0);
		  uVar3 = System_Action_long__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x18) = iVar4;
		    uVar3 = System_Action_long__TypeInfo;
		    iVar7 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1e0);
		        goto code_r0x80f9b807;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80f9b807:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar7 = *(int *)(iVar5 + 0x14);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Isles_Base_View_IsleBossContainer_CurrentCreateRequestChangedEvent__,0)
		  ;
		  piVar6 = (int *)func_ii_7048(uVar8,uVar3,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) ||
		          (*(int **)(iVar7 + 0x1c) = piVar6, *piVar6 != iVar5)) {
		    System_Activator__CreateInstance(piVar6,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Isles_Base_View_IsleBossContainer__Deinit(param1,piVar6);
		  *(undefined8 *)(param1 + 0x34) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005117 RID: 20759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005117")]
		[Address(RVA = "0x9F07", Offset = "0x9F07", VA = "0x9F07")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Gameplay_Isles_Base_View_IsleBossContainer__Deinit(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58ce7 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58ce7 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x2c),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar2,0);
		    *(undefined4 *)(param1 + 0x2c) = 0;
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x30),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar2,0);
		    *(undefined4 *)(param1 + 0x30) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005118 RID: 20760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005118")]
		[Address(RVA = "0x9F08", Offset = "0x9F08", VA = "0x9F08")]
		private void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_Isles_Base_View_IsleBossContainer__Clear(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58ce8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_IsleBossView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58ce8 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[0xb],0);
		  if (((iVar1 == 0) || (*(int *)(param1[0xb] + 0x3c) == 0)) ||
		     (param2 != *(int *)(param1[0xb] + 0x3c))) {
		    Gameplay_Isles_Base_View_IsleBossContainer__Deinit(param1,param1);
		    iVar1 = param1[9];
		    param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (param1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = func_ii_6805(iVar1,param2_00,Method_UnityEngine_Object_Instantiate_IsleBossView___);
		    param1[0xb] = iVar1;
		    Gameplay_Boss_View_WorldView_IsleBossView__set_BossInstance(iVar1,param2,0);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x10c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005119")]
		[Address(RVA = "0x9F09", Offset = "0x9F09", VA = "0x9F09")]
		public void ShowBoss(BossInstance instance)
		{
		/* --- GHIDRA: ShowBoss ---
		void Gameplay_Isles_Base_View_IsleBossContainer__ShowBoss
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a58ce9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_IsleBossCreateRequestView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58ce9 = '\x01';
		  }
		  Gameplay_Isles_Base_View_IsleBossContainer__Deinit(param1,param1);
		  iVar1 = param1[10];
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_6805(iVar1,param2_00,
		                       Method_UnityEngine_Object_Instantiate_IsleBossCreateRequestView___);
		  param1[0xc] = iVar1;
		  Gameplay_Boss_View_BossRewardsView___ctor(iVar1,param2,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,*(undefined4 *)(*param1 + 0x104));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))(param1,*(undefined4 *)(*param1 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x0600511A RID: 20762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511A")]
		[Address(RVA = "0x9F0A", Offset = "0x9F0A", VA = "0x9F0A")]
		public void CreateBossRequestView(BossCreateRequestData data)
		{
		/* --- GHIDRA: CreateBossRequestView ---
		void Gameplay_Isles_Base_View_IsleBossContainer__CreateBossRequestView(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x2c);
		    uVar2 = func_ii_4075(param1,0);
		    CloudsFly_BaseWorldObjectRenderer__get_SortingOrder(uVar3,uVar2,0);
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x30);
		    uVar2 = func_ii_4075(param1,0);
		    CloudsFly_BaseWorldObjectRenderer__get_SortingOrder(uVar3,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600511B RID: 20763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511B")]
		[Address(RVA = "0x9F0B", Offset = "0x9F0B", VA = "0x9F0B", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_Base_View_IsleBossContainer__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  if (iVar1 != 0) {
		    CloudsFly_BaseWorldObjectRenderer__get_SortingLayerId
		              (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(param1 + 0x18),0);
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if (iVar1 != 0) {
		    CloudsFly_BaseWorldObjectRenderer__get_SortingLayerId
		              (*(undefined4 *)(param1 + 0x30),*(undefined4 *)(param1 + 0x18),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511C")]
		[Address(RVA = "0x9F0C", Offset = "0x9F0C", VA = "0x9F0C", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511D")]
		[Address(RVA = "0x9F0D", Offset = "0x9F0D", VA = "0x9F0D")]
		public IsleBossContainer()
		{
		}

		// Token: 0x04002C29 RID: 11305
		[Token(Token = "0x4002C29")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private IsleBossView _bossWorldViewPrefab;

		// Token: 0x04002C2A RID: 11306
		[Token(Token = "0x4002C2A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IsleBossCreateRequestView _bossCreateRequestViewPrefab;

		// Token: 0x04002C2B RID: 11307
		[Token(Token = "0x4002C2B")]
		[FieldOffset(Offset = "0x2C")]
		private IsleBossView _bossWorldView;

		// Token: 0x04002C2C RID: 11308
		[Token(Token = "0x4002C2C")]
		[FieldOffset(Offset = "0x30")]
		private IsleBossCreateRequestView _bossCreateRequestView;

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x34")]
		private IIsle _isle;

		// Token: 0x04002C2E RID: 11310
		[Token(Token = "0x4002C2E")]
		[FieldOffset(Offset = "0x38")]
		private BaseIsleEvents _isleEvents;
	}
}
