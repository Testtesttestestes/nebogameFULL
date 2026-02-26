using System;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B5 RID: 4533
	[Token(Token = "0x20011B5")]
	public class BuildingUpgradedLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x00013E48 File Offset: 0x00012048
		[Token(Token = "0x170015FD")]
		public override int Id
		{
			[Token(Token = "0x6006BB7")]
			[Address(RVA = "0xB6A8", Offset = "0xB6A8", VA = "0xB6A8", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06006BB8 RID: 27576 RVA: 0x00013E60 File Offset: 0x00012060
		[Token(Token = "0x170015FE")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BB8")]
			[Address(RVA = "0xB6A9", Offset = "0xB6A9", VA = "0xB6A9", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB9")]
		[Address(RVA = "0xB6AA", Offset = "0xB6AA", VA = "0xB6AA", Slot = "8")]
		protected override void HandleInit()
		{
		/* --- GHIDRA: HandleInit ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__HandleInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__HandleSettingsChanged
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBA")]
		[Address(RVA = "0xB6AB", Offset = "0xB6AB", VA = "0xB6AB", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		/* --- GHIDRA: HandleSettingsChanged ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__HandleSettingsChanged
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  float fVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  float fVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  int iVar12;
		  int local_24;
		  undefined8 *puStack_20;
		  undefined8 local_1c;
		  int local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a695 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Values__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseBuildingData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseBuildingData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseBuildingData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__BaseBuildingData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a5a695 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = 0;
		  piVar11 = (int *)param1[2];
		  iVar12 = *piVar11;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x148);
		        goto code_r0x81252fd3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar11,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81252fd3:
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
		        goto code_r0x8125306f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar11,Core_Application_Managers_INotificationManager_TypeInfo,1);
		code_r0x8125306f:
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 + 0x110);
		        goto code_r0x81253109;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81253109:
		  iVar12 = (**(code **)((ulonglong)*puVar2 * 4))(piVar11,puVar2[1]);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)
		                      (*(int *)(*(int *)(*(int *)(iVar12 + 0x14) + 0x20) + 0x10) + 0x24),
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_24,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__BaseBuildingData__GetEnumerator__
		            );
		  local_8 = local_1c;
		  local_24 = 0;
		  puStack_20 = &local_10;
		  piVar11 = (int *)0x0;
		code_r0x81253179:
		  while (param1_00 = piVar11, param1_00 == (int *)0x0) {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseBuildingData__MoveNext__
		                        );
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        param1_00 = (int *)0x0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81253341;
		      }
		      if (iVar4 == 0) {
		        param1_00 = (int *)0x0;
		        goto code_r0x812533f2;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar11 = local_8._4_4_;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x323,local_8._4_4_,0);
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        param1_00 = (int *)0x0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81253341;
		      }
		    } while (iVar4 == 0);
		  }
		  while( true ) {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__BaseBuildingData__MoveNext__
		                        );
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81253341;
		      }
		      if (iVar4 == 0) goto code_r0x812533f2;
		      DAT_ram_009d3e38 = 0;
		      piVar11 = local_8._4_4_;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x323,local_8._4_4_,0);
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81253341;
		      }
		    } while (iVar4 == 0);
		    DAT_ram_009d3e38 = 0;
		    fVar9 = import::env::invoke_fii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,param1_00[5],0);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    fVar5 = import::env::invoke_fii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,piVar11[5],0);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81253341;
		    }
		    if (fVar9 < fVar5) goto code_r0x81253179;
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81253341:
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
		code_r0x812533f2:
		      DAT_ram_009d3e38 = 0;
		      if (param1_00 == (int *)0x0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      uVar1 = 0;
		      local_14 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param1_00,0);
		      local_14 = local_14 + 1;
		      uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		      System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                (uVar3,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		      uVar6 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xec));
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
		            goto code_r0x81253500;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar11,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81253500:
		      piVar11 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar11,puVar2[1]);
		      iVar12 = *param1;
		      uVar8 = (**(code **)((ulonglong)*(uint *)(iVar12 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(iVar12 + 0xec));
		      uVar6 = Core_GameLocalization__GetTranslation(uVar6,uVar3,0);
		      uVar3 = Core_GameLocalization__GetTranslation(uVar7,uVar3,0);
		      fVar9 = func_ii_7103(param1_00[5],0);
		      uVar7 = Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__NotificationEnabledChangedEvent
		                        (iVar12,iVar12,iVar12);
		      uVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0xfc));
		      iVar12 = *piVar11;
		      if (ABS(fVar9) < 2.1474836e+09) {
		        iVar4 = (int)fVar9;
		      }
		      else {
		        iVar4 = -0x80000000;
		      }
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Application_Managers_INotificationManager_TypeInfo ==
		              *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x81253609;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar11,Core_Application_Managers_INotificationManager_TypeInfo,
		                                    0);
		code_r0x81253609:
		      (**(code **)((ulonglong)*puVar2 * 4))(piVar11,uVar8,uVar6,uVar3,iVar4,uVar7,uVar10,puVar2[1]);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x324,&local_24);
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

		// Token: 0x06006BBB RID: 27579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBB")]
		[Address(RVA = "0xB6AC", Offset = "0xB6AC", VA = "0xB6AC")]
		private void ValidateNotification()
		{
		/* --- GHIDRA: ValidateNotification ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__ValidateNotification
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__HandleSettingsChanged
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBC")]
		[Address(RVA = "0xB6AD", Offset = "0xB6AD", VA = "0xB6AD")]
		private void BuildingStateChangedEvent(uint buildingId)
		{
		/* --- GHIDRA: BuildingStateChangedEvent ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__BuildingStateChangedEvent
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
		  
		  if (DAT_ram_00a5a696 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler_BuildingStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a696 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x8125370f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125370f:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(*(int *)(*(int *)(iVar5 + 0x14) + 0x20) + 0xc);
		  param1_01 = *(undefined4 *)(iVar6 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,
		                Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler_BuildingStateChangedEvent__
		                ,0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x14) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_uint__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x14) = iVar4;
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

		// Token: 0x06006BBD RID: 27581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBD")]
		[Address(RVA = "0xB6AE", Offset = "0xB6AE", VA = "0xB6AE", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBE")]
		[Address(RVA = "0xB6AF", Offset = "0xB6AF", VA = "0xB6AF")]
		public BuildingUpgradedLocalNotificationScheduler()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Channel ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__get_Channel
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
		  if (DAT_ram_00a5a694 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler_BuildingStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a694 = '\x01';
		  }
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__get_IsNotificationEnabled
		            (param1,0);
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x81252e0e;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81252e0e:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  iVar5 = *(int *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x20) + 0xc);
		  param1_01 = *(undefined4 *)(iVar5 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar2,param1,
		                Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler_BuildingStateChangedEvent__
		                ,0);
		  iVar4 = UnityEngine_UI_Image__set_sprite(param1_01,uVar2,0);
		  uVar2 = System_Action_uint__TypeInfo;
		  if (iVar4 == 0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		    Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__HandleSettingsChanged
		              (param1,0);
		    return;
		  }
		  iVar3 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar5 + 0x14) = iVar3;
		    uVar2 = System_Action_uint__TypeInfo;
		    iVar5 = func_ii_1082(iVar4,System_Action_uint__TypeInfo);
		    if (iVar5 != 0) {
		      Core_Gameplay_Managers_Notifications_Controller_Schedulers_BuildingUpgradedLocalNotificationScheduler__HandleSettingsChanged
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
