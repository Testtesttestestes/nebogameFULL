using System;
using System.Collections.Generic;
using Core.Events;
using Core.Events.Scopes;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D8 RID: 4824
	[Token(Token = "0x20012D8")]
	public class NotificationAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x060072B2 RID: 29362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173C")]
		protected override string Theme
		{
			[Token(Token = "0x60072B2")]
			[Address(RVA = "0xBCBB", Offset = "0xBCBB", VA = "0xBCBB", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B3")]
		[Address(RVA = "0xBCBC", Offset = "0xBCBC", VA = "0xBCBC", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param3_00;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int *piVar9;
		  undefined1 local_d;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a595f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Heavens_External_Common_IAppHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Heavens_External_Common_INotifications_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25654);
		    DAT_ram_00a595f6 = '\x01';
		  }
		  piVar6 = *(int **)(param2 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_string__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810389c8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_IEnumerable_string__TypeInfo,0);
		code_r0x810389c8:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81038aa1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81038fd2:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81038fda;
		    }
		code_r0x81038aa1:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81038fd2;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x81039023;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_string__TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81038b7b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_string__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81038f96:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81038fda;
		    }
		code_r0x81038b7b:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81038f96;
		    piVar6 = *(int **)(param1 + 8);
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iiii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,
		                           StringLiteral_25654,uVar4,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81038fda;
		    }
		    piVar8 = *(int **)(param2 + 8);
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (Core_Application_IApp_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 0x158);
		          goto code_r0x81038c90;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                        Core_Application_IApp_TypeInfo,0x13);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81038faa:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81038fda;
		    }
		code_r0x81038c90:
		    DAT_ram_009d3e38 = 0;
		    piVar8 = (int *)import::env::invoke_iii(*puVar3,piVar8,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81038faa;
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (OKG_Heavens_External_Common_IAppHolder_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 200);
		          goto code_r0x81038d61;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                        OKG_Heavens_External_Common_IAppHolder_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81038fb4:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81038fda;
		    }
		code_r0x81038d61:
		    DAT_ram_009d3e38 = 0;
		    piVar8 = (int *)import::env::invoke_iii(*puVar3,piVar8,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81038fb4;
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (OKG_Heavens_External_Common_INotifications_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x81038e32;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                        OKG_Heavens_External_Common_INotifications_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81038fbe:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81038fda;
		    }
		code_r0x81038e32:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii(*puVar3,piVar8,uVar4,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81038fbe;
		    local_d = (undefined1)uVar4;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66944,
		                       &local_d);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x81038f45;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81038f45:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar3,piVar6,param3_00,uVar4,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81038fda:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar7 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x81039023:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8103909b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8103909b:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x339,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B4")]
		[Address(RVA = "0xBCBD", Offset = "0xBCBD", VA = "0xBCBD")]
		private void NotificationChannelsInitializedEvent(NotificationScope.NotificationChannelEventArgs e)
		{
		/* --- GHIDRA: NotificationChannelsInitializedEvent ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationChannelsInitializedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a595f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a595f7 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0xc);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x260);
		        goto code_r0x81039197;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x34);
		code_r0x81039197:
		  iVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		  Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationSettingsChangedEvent
		            (param1,*(undefined4 *)(iVar2 + 0x14),param3_00);
		  return;
		}
		*/

		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B5")]
		[Address(RVA = "0xBCBE", Offset = "0xBCBE", VA = "0xBCBE")]
		private void NotificationSettingsInitializedEvent(BaseEventBusEventArgs e)
		{
		/* --- GHIDRA: NotificationSettingsInitializedEvent ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationSettingsInitializedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined1 local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24253);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24252);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24254);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25660);
		    DAT_ram_00a595f8 = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x260);
		        goto code_r0x81039613;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x34);
		code_r0x81039613:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationSettingsChangedEvent
		            (param1,*(undefined4 *)(iVar6 + 0x14),puVar2);
		  uVar1 = 0;
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0xc);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_24253,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar3 = Core_Gameplay_Managers_Notifications_Model_NotificationGroupData__get_SortOrder
		                    (*(undefined4 *)(param2 + 0x10),0);
		  func_ii_2946(param1_00,StringLiteral_24254,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_5 = *(undefined1 *)(*(int *)(param2 + 0x10) + 0x10);
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_5);
		  func_ii_2946(param1_00,StringLiteral_24252,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_25660;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81039769;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81039769:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,uVar3,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B6")]
		[Address(RVA = "0xBCBF", Offset = "0xBCBF", VA = "0xBCBF")]
		private void NotificationSettingsChangedEvent(NotificationScope.NotificationSettingsEventArgs e)
		{
		/* --- GHIDRA: NotificationSettingsChangedEvent ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationSettingsChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  undefined1 local_1d;
		  int local_1c;
		  undefined8 *local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a595f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_uint__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_uint__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_uint__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25657);
		    DAT_ram_00a595f9 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = 0;
		  if (*(int *)(param2 + 0x14) == 0) {
		    return;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(int *)(param2 + 0x14),
		             Method_System_Collections_Generic_List_uint__GetEnumerator__);
		  local_1c = 0;
		  local_18 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3b9,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_uint__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8103949b;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    local_14 = local_8._4_4_;
		    piVar6 = *(int **)(param1 + 8);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_14,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8103949b;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,StringLiteral_25657,
		                       uVar5,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8103949b;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33a,param2,local_14,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8103949b;
		    }
		    local_1d = (undefined1)uVar3;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66944,
		                       &local_1d);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (Core_Analytics_Service_IAnalyticsApi_TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x8103941c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8103941c:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar4,piVar6,uVar5,uVar3,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8103949b:
		  iVar7 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar2) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar2 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_1c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33b,&local_1c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B7")]
		[Address(RVA = "0xBCC0", Offset = "0xBCC0", VA = "0xBCC0")]
		private void SetSettings(GameNotificationsModel gameNotificationsModel)
		{
		/* --- GHIDRA: SetSettings ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__SetSettings
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a595fa == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25659);
		    DAT_ram_00a595fa = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationScopeOnNotificationReceivedEvent
		            (param1,param2_00,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_25659;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81039857;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81039857:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B8")]
		[Address(RVA = "0xBCC1", Offset = "0xBCC1", VA = "0xBCC1")]
		private void NotificationScopeOnNotificationReceivedEvent(NotificationScope.NotificationEventArgs e)
		{
		/* --- GHIDRA: NotificationScopeOnNotificationReceivedEvent ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationScopeOnNotificationReceivedEvent
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a595fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__object__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__object__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__object__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__object__get_Value__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25653);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25661);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25658);
		    DAT_ram_00a595fb = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  func_ii_2946(param2,StringLiteral_25658,*(undefined4 *)(param3 + 0x10),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param2,StringLiteral_25661,*(undefined4 *)(param3 + 0x14),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  func_ii_2946(param2,StringLiteral_25653,*(undefined4 *)(param3 + 0x18),
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  if (*(int *)(param3 + 0x1c) == 0) {
		    return;
		  }
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,*(int *)(param3 + 0x1c),
		             Method_System_Collections_Generic_Dictionary_string__object__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__object__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81039a17;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param2,uStack_c,local_8,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81039a17:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33c,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B9")]
		[Address(RVA = "0xBCC2", Offset = "0xBCC2", VA = "0xBCC2")]
		private void AppendEventProperties(Dictionary<string, object> properties, NotificationScope.NotificationEventArgs e)
		{
		/* --- GHIDRA: AppendEventProperties ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__AppendEventProperties
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param2_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a595fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25655);
		    DAT_ram_00a595fc = '\x01';
		  }
		  param2_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationScopeOnNotificationReceivedEvent
		            (param1,param2_00,param2,param1);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar1 = StringLiteral_25655;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81039b97;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81039b97:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,uVar1,param2_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072BA RID: 29370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BA")]
		[Address(RVA = "0xBCC3", Offset = "0xBCC3", VA = "0xBCC3")]
		private void NotificationScopeOnNotificationClickedEvent(NotificationScope.NotificationEventArgs e)
		{
		/* --- GHIDRA: NotificationScopeOnNotificationClickedEvent ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__NotificationScopeOnNotificationClickedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationChannelsInitializedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationScopeOnNotificationClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationScopeOnNotificationReceivedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationSettingsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationSettingsInitializedEvent__
		              );
		    DAT_ram_00a595fd = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationScopeOnNotificationClickedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_NotificationScope_NotificationEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_NotificationScope_NotificationEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationScopeOnNotificationReceivedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_NotificationScope_NotificationEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_NotificationScope_NotificationEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417
		                    (System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationSettingsChangedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,
		                         System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationSettingsInitializedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417
		                    (System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationChannelsInitializedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo)
		  ;
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072BB RID: 29371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BB")]
		[Address(RVA = "0xBCC4", Offset = "0xBCC4", VA = "0xBCC4", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BC")]
		[Address(RVA = "0xBCC5", Offset = "0xBCC5", VA = "0xBCC5")]
		public NotificationAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_NotificationAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595fe == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25428);
		    DAT_ram_00a595fe = '\x01';
		  }
		  return StringLiteral_25428;
		}
		*/

		}

		// Token: 0x04003C13 RID: 15379
		[Token(Token = "0x4003C13")]
		private const string NOTIFICATION_RECEIVED = "notification_received";

		// Token: 0x04003C14 RID: 15380
		[Token(Token = "0x4003C14")]
		private const string NOTIFICATION_CLICKED = "notification_clicked";

		// Token: 0x04003C15 RID: 15381
		[Token(Token = "0x4003C15")]
		private const string NOTIFICATION_SETTINGS_CHANGED = "notification_settings_changed";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_NotificationAnalyticsListener__get_Theme
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a595f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationChannelsInitializedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationScopeOnNotificationClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationScopeOnNotificationReceivedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationSettingsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationSettingsInitializedEvent__
		              );
		    DAT_ram_00a595f5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationScopeOnNotificationClickedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_NotificationScope_NotificationEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_NotificationScope_NotificationEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationScopeOnNotificationReceivedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_NotificationScope_NotificationEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_NotificationScope_NotificationEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417
		                    (System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationSettingsChangedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x10) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,
		                         System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x10) = iVar3;
		    uVar2 = System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_NotificationScope_NotificationSettingsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationSettingsInitializedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x8c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x18);
		  uVar2 = unnamed_function_1417
		                    (System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_NotificationAnalyticsListener_NotificationChannelsInitializedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo)
		  ;
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x18) = iVar3;
		    uVar2 = System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,
		                         System_Action_NotificationScope_NotificationChannelEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
