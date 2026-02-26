using System;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B7 RID: 4535
	[Token(Token = "0x20011B7")]
	public class DailyQuestUncompletedLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06006BC6 RID: 27590 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x17001601")]
		public override int Id
		{
			[Token(Token = "0x6006BC6")]
			[Address(RVA = "0xB6B7", Offset = "0xB6B7", VA = "0xB6B7", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x17001602")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BC7")]
			[Address(RVA = "0xB6B8", Offset = "0xB6B8", VA = "0xB6B8", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x00013ED8 File Offset: 0x000120D8
		[Token(Token = "0x17001603")]
		private float MinBacktime
		{
			[Token(Token = "0x6006BC8")]
			[Address(RVA = "0x2229", Offset = "0x2229", VA = "0x2229")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC9")]
		[Address(RVA = "0xB6B9", Offset = "0xB6B9", VA = "0xB6B9", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCA")]
		[Address(RVA = "0xB6BA", Offset = "0xB6BA", VA = "0xB6BA")]
		private void ActiveQuestsCountChangedEvent()
		{
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCB")]
		[Address(RVA = "0xB6BB", Offset = "0xB6BB", VA = "0xB6BB", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		/* --- GHIDRA: HandleSettingsChanged ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler__HandleSettingsChanged
		               (int *param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int *param2_01;
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  float fVar9;
		  float fVar10;
		  undefined4 uVar11;
		  int *piVar12;
		  int iVar13;
		  int *piVar14;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a69c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDailyQuest__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDailyQuest__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDailyQuest__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IDailyQuest__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27734);
		    DAT_ram_00a5a69c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  piVar12 = (int *)param1[2];
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x148);
		        goto code_r0x81254417;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81254417:
		  piVar12 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = 0;
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 200);
		        goto code_r0x812544b3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,Core_Application_Managers_INotificationManager_TypeInfo,1);
		code_r0x812544b3:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar12,uVar3,puVar2[1]);
		  iVar13 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0xf4));
		  if (iVar13 == 0) {
		    return;
		  }
		  uVar1 = 0;
		  piVar12 = (int *)param1[3];
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x170);
		        goto code_r0x81254551;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x81254551:
		  iVar13 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(*(int *)(iVar13 + 0x1c) + 0x14),
		             Method_System_Collections_Generic_List_IDailyQuest__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		  piVar12 = (int *)0x0;
		code_r0x812545be:
		  param2_01 = piVar12;
		  DAT_ram_009d3e38 = 0;
		  iVar4 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                     Method_System_Collections_Generic_List_Enumerator_IDailyQuest__MoveNext__);
		  iVar13 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar13 != 1) {
		    if (iVar4 == 0) goto code_r0x81254b5c;
		    param2_00 = local_8._4_4_;
		    iVar13 = *local_8._4_4_;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *piVar12) {
		          puVar5 = (undefined4 *)(piVar12[1] * 8 + iVar13 + 0xe0);
		          goto code_r0x81254695;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Gameplay_DailyQuests_Model_IQuest_TypeInfo,4);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81254af4:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81254b06;
		    }
		code_r0x81254695:
		    DAT_ram_009d3e38 = 0;
		    iVar13 = import::env::invoke_iii(*puVar5,param2_00,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81254af4;
		    piVar12 = param2_01;
		    if (iVar13 == 0) {
		      iVar13 = *param2_00;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar14 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		          if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *piVar14) {
		            puVar5 = (undefined4 *)(piVar14[1] * 8 + iVar13 + 0xd0);
		            goto code_r0x8125476a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2_00,
		                          Gameplay_DailyQuests_Model_IQuest_TypeInfo,2);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x8125476a:
		        DAT_ram_009d3e38 = 0;
		        fVar9 = import::env::invoke_fii(*puVar5,param2_00,puVar5[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          if (0.0 < fVar9) {
		            iVar13 = *param2_00;
		            if (*(ushort *)(iVar13 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar14 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		                if (Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo == *piVar14) {
		                  puVar5 = (undefined4 *)(iVar13 + piVar14[1] * 8 + 0xc0);
		                  goto code_r0x81254854;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2_00,
		                                Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo,0);
		            if (DAT_ram_009d3e38 != 1) {
		code_r0x81254854:
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::invoke_iii(*puVar5,param2_00,puVar5[1]);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                fVar9 = import::env::invoke_fii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,uVar3,0);
		                iVar13 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar13 == 1) {
		                  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81254b06;
		                }
		                DAT_ram_009d3e38 = 0;
		                fVar10 = import::env::invoke_fii
		                                   (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x325,param1,
		                                    iVar13);
		                iVar13 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar13 == 1) {
		                  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81254b06;
		                }
		                if ((fVar10 < fVar9) && (piVar12 = param2_00, param2_01 != (int *)0x0)) {
		                  iVar13 = *param2_01;
		                  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		                    uVar1 = 0;
		                    do {
		                      piVar14 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		                      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *piVar14) {
		                        puVar5 = (undefined4 *)(piVar14[1] * 8 + iVar13 + 0xd0);
		                        goto code_r0x812549b0;
		                      }
		                      uVar1 = uVar1 + 1;
		                    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  puVar5 = (undefined4 *)
		                           import::env::invoke_iiii
		                                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                      param2_01,Gameplay_DailyQuests_Model_IQuest_TypeInfo,2);
		                  if (DAT_ram_009d3e38 != 1) {
		code_r0x812549b0:
		                    DAT_ram_009d3e38 = 0;
		                    fVar9 = import::env::invoke_fii(*puVar5,param2_01,puVar5[1]);
		                    if (DAT_ram_009d3e38 != 1) {
		                      iVar13 = *param2_00;
		                      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		                        uVar1 = 0;
		                        do {
		                          piVar14 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		                          if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *piVar14) {
		                            puVar5 = (undefined4 *)(piVar14[1] * 8 + iVar13 + 0xd0);
		                            goto code_r0x81254a81;
		                          }
		                          uVar1 = uVar1 + 1;
		                        } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      puVar5 = (undefined4 *)
		                               import::env::invoke_iiii
		                                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                          param2_00,Gameplay_DailyQuests_Model_IQuest_TypeInfo,2);
		                      if (DAT_ram_009d3e38 != 1) {
		code_r0x81254a81:
		                        DAT_ram_009d3e38 = 0;
		                        fVar10 = import::env::invoke_fii(*puVar5,param2_00,puVar5[1]);
		                        if (DAT_ram_009d3e38 != 1) {
		                          if (fVar10 <= fVar9) {
		                            piVar12 = param2_01;
		                          }
		                          goto code_r0x812545be;
		                        }
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x81254b06;
		                    }
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81254b06;
		                }
		                goto code_r0x812545be;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81254b06;
		          }
		          goto code_r0x812545be;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81254b06;
		    }
		    goto code_r0x812545be;
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81254b06:
		  iVar13 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar13 == iVar4) {
		    piVar12 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar12;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar13 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar13 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81254b5c:
		      DAT_ram_009d3e38 = 0;
		      if (param2_01 == (int *)0x0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      uVar1 = 0;
		      uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		      System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                (uVar3,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		      iVar13 = *param2_01;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        do {
		          if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		              *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x110
		                             );
		            goto code_r0x81254c1e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2_01,Gameplay_DailyQuests_Model_IQuest_TypeInfo,10);
		code_r0x81254c1e:
		      uVar1 = 0;
		      uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2_01,puVar2[1]);
		      System_Reflection_FieldInfo__get_IsStatic
		                (uVar3,StringLiteral_27734,uVar6,
		                 Method_System_Collections_Generic_Dictionary_string__string__Add__);
		      uVar6 = Core_Extensions_Dict_ItemQualityDicExt__GetTitle(param1[4],0);
		      uVar7 = Core_Extensions_Dict_LocalNotificationDicExt__GetTitle(param1[4],0);
		      piVar12 = (int *)param1[2];
		      iVar13 = *piVar12;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x148
		                             );
		            goto code_r0x81254cd5;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar12,Core_Application_IApp_TypeInfo,0x11);
		code_r0x81254cd5:
		      piVar12 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		      uVar1 = 0;
		      uVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      uVar6 = Core_GameLocalization__GetTranslation(uVar6,uVar3,0);
		      uVar3 = Core_GameLocalization__GetTranslation(uVar7,uVar3,0);
		      iVar13 = *param2_01;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        do {
		          if (Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo ==
		              *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x81254d89;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2_01,Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo,0);
		code_r0x81254d89:
		      uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param2_01,puVar2[1]);
		      fVar9 = func_ii_7103(uVar7,0);
		      fVar10 = func_ii_8744(param1,puVar2);
		      if (ABS(fVar9 - fVar10) < 2.1474836e+09) {
		        iVar13 = (int)(fVar9 - fVar10);
		      }
		      else {
		        iVar13 = -0x80000000;
		      }
		      uVar7 = Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractBaseNotificationScheduler__NotificationEnabledChangedEvent
		                        (puVar2,puVar2,puVar2);
		      uVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0xfc));
		      iVar4 = *piVar12;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Application_Managers_INotificationManager_TypeInfo ==
		              *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81254e5e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar12,Core_Application_Managers_INotificationManager_TypeInfo,
		                                    0);
		code_r0x81254e5e:
		      (**(code **)((ulonglong)*puVar2 * 4))(piVar12,uVar8,uVar6,uVar3,iVar13,uVar7,uVar11,puVar2[1])
		      ;
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x326,&local_20);
		  iVar13 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar13 == 1) {
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

		// Token: 0x06006BCC RID: 27596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCC")]
		[Address(RVA = "0xB6BC", Offset = "0xB6BC", VA = "0xB6BC")]
		private void ValidateNotification()
		{
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCD")]
		[Address(RVA = "0xB6BD", Offset = "0xB6BD", VA = "0xB6BD")]
		private void QuestsUpdatedEvent()
		{
		/* --- GHIDRA: QuestsUpdatedEvent ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler__QuestsUpdatedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler__HandleSettingsChanged
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCE")]
		[Address(RVA = "0xB6BE", Offset = "0xB6BE", VA = "0xB6BE")]
		private void QuestsChangedEvent()
		{
		/* --- GHIDRA: QuestsChangedEvent ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler__QuestsChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a5a69d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_ActiveQuestsCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_QuestsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_QuestsUpdatedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a69d = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  piVar4 = *(int **)(param1 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x81254f4d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x81254f4d:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  uVar7 = *(undefined4 *)(iVar6 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_QuestsChangedEvent__
		             ,0);
		  piVar4 = (int *)func_ii_7048(uVar7,uVar3,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar6 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar6 + 0x14) = piVar4, *piVar4 != iVar5)) {
		    System_Activator__CreateInstance(piVar4,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x8125503c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x8125503c:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  uVar7 = *(undefined4 *)(iVar6 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_QuestsUpdatedEvent__
		             ,0);
		  piVar4 = (int *)func_ii_7048(uVar7,uVar3,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar6 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar6 + 0x1c) = piVar4, *piVar4 != iVar5)) {
		    System_Activator__CreateInstance(piVar4,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x81255125;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x81255125:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  uVar7 = *(undefined4 *)(iVar6 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_ActiveQuestsCountChangedEvent__
		             ,0);
		  piVar4 = (int *)func_ii_7048(uVar7,uVar3,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar4) && (*(int **)(iVar6 + 0x18) = piVar4, *piVar4 == iVar5)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar4,iVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCF")]
		[Address(RVA = "0xB6BF", Offset = "0xB6BF", VA = "0xB6BF", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD0")]
		[Address(RVA = "0xB6C0", Offset = "0xB6C0", VA = "0xB6C0")]
		public DailyQuestUncompletedLocalNotificationScheduler()
		{
		}

		// Token: 0x040038D3 RID: 14547
		[Token(Token = "0x40038D3")]
		[FieldOffset(Offset = "0x14")]
		private float? _minBacktime;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Channel ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler__get_Channel
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a69b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_ActiveQuestsCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_QuestsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_QuestsUpdatedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a69b = '\x01';
		  }
		  Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__get_IsNotificationEnabled
		            (param1,0);
		  piVar4 = *(int **)(param1 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x81254095;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x81254095:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  uVar7 = *(undefined4 *)(iVar6 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_QuestsChangedEvent__
		             ,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar7,uVar3,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar6 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar6 + 0x14) = piVar4, *piVar4 != iVar5)) {
		    System_Activator__CreateInstance(piVar4,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x81254184;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x81254184:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  uVar7 = *(undefined4 *)(iVar6 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_QuestsUpdatedEvent__
		             ,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar7,uVar3,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar6 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar6 + 0x1c) = piVar4, *piVar4 != iVar5)) {
		    System_Activator__CreateInstance(piVar4,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x170);
		        goto code_r0x8125426d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x8125426d:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  uVar7 = *(undefined4 *)(iVar6 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler_ActiveQuestsCountChangedEvent__
		             ,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar7,uVar3,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		    Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler__HandleSettingsChanged
		              (param1,0);
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar4) && (*(int **)(iVar6 + 0x18) = piVar4, *piVar4 == iVar5)) {
		    Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler__HandleSettingsChanged
		              (param1,piVar4);
		    return;
		  }
		  System_Activator__CreateInstance(piVar4,iVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_MinBacktime ---
		int * Core_Gameplay_Managers_Notifications_Controller_Schedulers_DailyQuestUncompletedLocalNotificationScheduler__get_MinBacktime
		                (int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
