using System;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011BB RID: 4539
	[Token(Token = "0x20011BB")]
	public class SpellLeanedLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06006BEC RID: 27628 RVA: 0x00013FB0 File Offset: 0x000121B0
		[Token(Token = "0x1700160C")]
		public override int Id
		{
			[Token(Token = "0x6006BEC")]
			[Address(RVA = "0xB6DC", Offset = "0xB6DC", VA = "0xB6DC", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06006BED RID: 27629 RVA: 0x00013FC8 File Offset: 0x000121C8
		[Token(Token = "0x1700160D")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BED")]
			[Address(RVA = "0xB6DD", Offset = "0xB6DD", VA = "0xB6DD", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEE")]
		[Address(RVA = "0xB6DE", Offset = "0xB6DE", VA = "0xB6DE", Slot = "8")]
		protected override void HandleInit()
		{
		/* --- GHIDRA: HandleInit ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__HandleInit
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__HandleSettingsChanged
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEF")]
		[Address(RVA = "0xB6DF", Offset = "0xB6DF", VA = "0xB6DF")]
		private void SpellStateChanged(uint spellId)
		{
		/* --- GHIDRA: SpellStateChanged ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__SpellStateChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__HandleSettingsChanged
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF0")]
		[Address(RVA = "0xB6E0", Offset = "0xB6E0", VA = "0xB6E0", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		/* --- GHIDRA: HandleSettingsChanged ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__HandleSettingsChanged
		               (int *param1,undefined4 param2)
		
		{
		  int *param2_00;
		  uint uVar1;
		  int *param2_01;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  int iVar12;
		  int local_24;
		  undefined8 *puStack_20;
		  undefined8 local_1c;
		  int local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a6a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Values__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__SchoolSpellData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__SchoolSpellData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__SchoolSpellData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__SchoolSpellData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a5a6a8 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = 0;
		  piVar11 = (int *)param1[2];
		  iVar12 = *piVar11;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x148);
		        goto code_r0x812566f2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar11,Core_Application_IApp_TypeInfo,0x11);
		code_r0x812566f2:
		  piVar11 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar11,puVar2[1]);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = 0;
		  iVar12 = *piVar11;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 200);
		        goto code_r0x8125678e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar11,Core_Application_Managers_INotificationManager_TypeInfo,1);
		code_r0x8125678e:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar11,uVar3,puVar2[1]);
		  iVar12 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0xf4));
		  if (iVar12 == 0) {
		    return;
		  }
		  uVar1 = 0;
		  piVar11 = (int *)param1[3];
		  iVar12 = *piVar11;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x128);
		        goto code_r0x8125682c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0xd);
		code_r0x8125682c:
		  iVar12 = (**(code **)((ulonglong)*puVar2 * 4))(piVar11,puVar2[1]);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(*(int *)(iVar12 + 0x14) + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_24,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__SchoolSpellData__GetEnumerator__
		            );
		  local_8 = local_1c;
		  local_24 = 0;
		  puStack_20 = &local_10;
		  piVar11 = (int *)0x0;
		  while( true ) {
		    param2_01 = piVar11;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__SchoolSpellData__MoveNext__
		                      );
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) break;
		    if (iVar4 == 0) goto code_r0x81256a1f;
		    DAT_ram_009d3e38 = 0;
		    param2_00 = local_8._4_4_;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x327,local_8._4_4_,0);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812569c9;
		    }
		    piVar11 = param2_01;
		    if ((iVar4 != 0) && (piVar11 = param2_00, param2_01 != (int *)0x0)) {
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x327,param2_01,0);
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812569c9;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x327,param2_00,0);
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812569c9;
		      }
		      if (uVar5 <= uVar1) {
		        piVar11 = param2_01;
		      }
		    }
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812569c9:
		  iVar12 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar12 == iVar4) {
		    piVar11 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar11;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81256a1f:
		      DAT_ram_009d3e38 = 0;
		      if (param2_01 == (int *)0x0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      local_14 = (**(code **)((ulonglong)*(uint *)(*param2_01 + 0xf0) * 4))
		                           (param2_01,*(undefined4 *)(*param2_01 + 0xf4));
		      local_14 = local_14 + 1;
		      uVar1 = 0;
		      uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		      System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                (uVar3,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		      uVar6 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId(param2_01[3],0);
		      System_Reflection_FieldInfo__get_IsStatic
		                (uVar3,StringLiteral_27734,uVar6,
		                 Method_System_Collections_Generic_Dictionary_string__string__Add__);
		      uVar6 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_14,0);
		      System_Reflection_FieldInfo__get_IsStatic
		                (uVar3,StringLiteral_25096,uVar6,
		                 Method_System_Collections_Generic_Dictionary_string__string__Add__);
		      uVar6 = Core_Extensions_Dict_ItemQualityDicExt__GetTitle(param1[4],0);
		      uVar7 = Core_Extensions_Dict_LocalNotificationDicExt__GetTitle(param1[4],0);
		      piVar11 = (int *)param1[2];
		      iVar12 = *piVar11;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x148
		                             );
		            goto code_r0x81256b6b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar11,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81256b6b:
		      piVar11 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar11,puVar2[1]);
		      uVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      uVar6 = Core_GameLocalization__GetTranslation(uVar6,uVar3,0);
		      uVar3 = Core_GameLocalization__GetTranslation(uVar7,uVar3,0);
		      uVar7 = func_ii_8746(param2_01,0);
		      uVar1 = 0;
		      uVar9 = Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__NotificationEnabledChangedEvent
		                        (0,0,0);
		      uVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0xfc));
		      iVar12 = *piVar11;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        do {
		          if (Core_Application_Managers_INotificationManager_TypeInfo ==
		              *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x81256c55;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar11,Core_Application_Managers_INotificationManager_TypeInfo,
		                                    0);
		code_r0x81256c55:
		      (**(code **)((ulonglong)*puVar2 * 4))(piVar11,uVar8,uVar6,uVar3,uVar7,uVar9,uVar10,puVar2[1]);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x328,&local_24);
		  iVar12 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar12 == 1) {
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
		*/

		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF1")]
		[Address(RVA = "0xB6E1", Offset = "0xB6E1", VA = "0xB6E1")]
		private void ValidateNotification()
		{
		/* --- GHIDRA: ValidateNotification ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__ValidateNotification
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a6a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler_SpellStateChanged__
		              );
		    DAT_ram_00a5a6a9 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x128);
		        goto code_r0x81256d65;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xd);
		code_r0x81256d65:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x10);
		  param1_01 = *(undefined4 *)(iVar6 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,
		                Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler_SpellStateChanged__
		                ,0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x20) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_uint__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x20) = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_uint__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF2")]
		[Address(RVA = "0xB6E2", Offset = "0xB6E2", VA = "0xB6E2", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF3")]
		[Address(RVA = "0xB6E3", Offset = "0xB6E3", VA = "0xB6E3")]
		public SpellLeanedLocalNotificationScheduler()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6aa = '\x01';
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

		/* --- GHIDRA: get_Channel ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__get_Channel
		               (int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  uint uVar6;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a5a6a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler_SpellStateChanged__
		              );
		    DAT_ram_00a5a6a7 = '\x01';
		  }
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__get_IsNotificationEnabled
		            (param1,0);
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x128);
		        goto code_r0x81256541;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xd);
		code_r0x81256541:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  iVar5 = *(int *)(iVar4 + 0x10);
		  param1_01 = *(undefined4 *)(iVar5 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar2,param1,
		                Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler_SpellStateChanged__
		                ,0);
		  iVar4 = UnityEngine_UI_Image__set_sprite(param1_01,uVar2,0);
		  uVar2 = System_Action_uint__TypeInfo;
		  if (iVar4 == 0) {
		    *(undefined4 *)(iVar5 + 0x20) = 0;
		    Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__HandleSettingsChanged
		              (param1,0);
		    return;
		  }
		  iVar3 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar5 + 0x20) = iVar3;
		    uVar2 = System_Action_uint__TypeInfo;
		    iVar5 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		    if (iVar5 != 0) {
		      Core_Gameplay_Managers_Notifications_Controller_Schedulers_SpellLeanedLocalNotificationScheduler__HandleSettingsChanged
		                (param1,iVar4);
		      return;
		    }
		    System_Activator__CreateInstance(iVar4,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar4,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
