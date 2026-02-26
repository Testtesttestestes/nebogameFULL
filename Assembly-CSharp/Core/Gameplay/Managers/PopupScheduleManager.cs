using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloudsFly.Movement;
using DG.Tweening;
using Il2CppDummyDll;
using UI.Windows;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200116B RID: 4459
	[Token(Token = "0x200116B")]
	public class PopupScheduleManager : IGameManager, IBaseManager
	{
		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x0600695B RID: 26971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158F")]
		public string Name
		{
			[Token(Token = "0x600695B")]
			[Address(RVA = "0xB47F", Offset = "0xB47F", VA = "0xB47F", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400028E RID: 654
		// (add) Token: 0x0600695C RID: 26972 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600695D RID: 26973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028E")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600695C")]
			[Address(RVA = "0xB480", Offset = "0xB480", VA = "0xB480", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600695D")]
			[Address(RVA = "0xB481", Offset = "0xB481", VA = "0xB481", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400028F RID: 655
		// (add) Token: 0x0600695E RID: 26974 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600695F RID: 26975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028F")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600695E")]
			[Address(RVA = "0xB482", Offset = "0xB482", VA = "0xB482", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600695F")]
			[Address(RVA = "0xB483", Offset = "0xB483", VA = "0xB483", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006960")]
		[Address(RVA = "0xB484", Offset = "0xB484", VA = "0xB484")]
		public PopupScheduleManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_PopupScheduleManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_00;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a637fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Scenes__Contains__);
		    DAT_ram_00a637fc = '\x01';
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 799,0);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 10,uVar2,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        uVar1 = 0;
		        if (iVar3 != 0) {
		          DAT_ram_009d3e38 = 0;
		          return 0;
		        }
		        piVar5 = *(int **)(param1 + 0x18);
		        iVar6 = *piVar5;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar4 = (undefined4 *)
		                       (*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1e8);
		              goto code_r0x823037b3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                            Core_Gameplay_IGame_TypeInfo,0x25);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x823037b3:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) {
		            iVar3 = **(int **)(iVar6 + 0x10);
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iii
		                              (*(undefined4 *)(iVar3 + 0x100),*(int **)(iVar6 + 0x10),
		                               *(undefined4 *)(iVar3 + 0x104));
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              if (*(int *)(iVar3 + 0x24) != 0) {
		                DAT_ram_009d3e38 = 0;
		                return 0;
		              }
		              DAT_ram_009d3e38 = 0;
		              iVar3 = import::env::invoke_ii
		                                (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0xb,0);
		              iVar6 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar6 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                iVar3 = import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x38,
		                                   *(undefined4 *)(iVar3 + 0x10),2,
		                                   Method_System_Collections_Generic_List_Scenes__Contains__);
		                iVar6 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar6 == 1) {
		                  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		                else {
		                  uVar1 = 0;
		                  if (iVar3 == 0) {
		                    DAT_ram_009d3e38 = 0;
		                    return 0;
		                  }
		                  piVar5 = *(int **)(param1 + 0x18);
		                  iVar6 = *piVar5;
		                  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                    do {
		                      if (Core_Gameplay_IGame_TypeInfo ==
		                          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		                        puVar4 = (undefined4 *)
		                                 (*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 +
		                                 0x218);
		                        goto code_r0x82303987;
		                      }
		                      uVar1 = uVar1 + 1;
		                    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  puVar4 = (undefined4 *)
		                           import::env::invoke_iiii
		                                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                                      Core_Gameplay_IGame_TypeInfo,0x2b);
		                  if (DAT_ram_009d3e38 != 1) {
		code_r0x82303987:
		                    DAT_ram_009d3e38 = 0;
		                    piVar5 = (int *)import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		                    if (DAT_ram_009d3e38 != 1) {
		                      iVar6 = *piVar5;
		                      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                        uVar1 = 0;
		                        do {
		                          if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		                              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		                            puVar4 = (undefined4 *)
		                                     (iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                     0xc0);
		                            goto code_r0x82303a5c;
		                          }
		                          uVar1 = uVar1 + 1;
		                        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      puVar4 = (undefined4 *)
		                               import::env::invoke_iiii
		                                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                          piVar5,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		                      if (DAT_ram_009d3e38 != 1) {
		code_r0x82303a5c:
		                        DAT_ram_009d3e38 = 0;
		                        iVar3 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		                        iVar6 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar6 != 1) {
		                          return (uint)(iVar3 == 0);
		                        }
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x82303ab0;
		                    }
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		              }
		            }
		            goto code_r0x82303ab0;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x82303ab0:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_NullReferenceException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar3 != 0) {
		          import::env::__cxa_end_catch();
		          return 0;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x82303bb9;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x82303bb9:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x00013980 File Offset: 0x00011B80
		[Token(Token = "0x17001590")]
		public bool IsPlayerIdle
		{
			[Token(Token = "0x6006961")]
			[Address(RVA = "0xB485", Offset = "0xB485", VA = "0xB485")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006962")]
		[Address(RVA = "0xB486", Offset = "0xB486", VA = "0xB486", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_PopupScheduleManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a637fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_string__WindowCloseReason__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_PopupScheduleManager_HandleOnWindowClosedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_PopupScheduleManager_MovCompleteEvent__);
		    DAT_ram_00a637fe = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x82303f1f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x82303f1f:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 8);
		  uVar8 = *(undefined4 *)(iVar7 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,Method_Core_Gameplay_Managers_PopupScheduleManager_MovCompleteEvent__,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x82304016;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82304016:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x82304098;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x82304098:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar8 = unnamed_function_1417(System_Action_string__WindowCloseReason__TypeInfo);
		  System_Action_object__int___Invoke
		            (uVar8,param1,
		             Method_Core_Gameplay_Managers_PopupScheduleManager_HandleOnWindowClosedEvent__,0);
		  UI_Windows_PopupController__remove_OnWindowOpenedEvent(uVar3,uVar8,0);
		  iVar6 = *(int *)(param1 + 8);
		  if (iVar6 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		              (*(undefined4 *)(iVar6 + 0x20),param1,*(undefined4 *)(iVar6 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006963 RID: 26979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006963")]
		[Address(RVA = "0xB487", Offset = "0xB487", VA = "0xB487", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_PopupScheduleManager__Init
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a637ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a637ff = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xf0);
		        goto code_r0x82304195;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,6);
		code_r0x82304195:
		  iVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		  if (iVar2 != 0) {
		    Core_Gameplay_Managers_PopupScheduleManager__ScheduleNext(param1,4,param3_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006964 RID: 26980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006964")]
		[Address(RVA = "0xB488", Offset = "0xB488", VA = "0xB488")]
		private void HandleOnWindowClosedEvent(string windowId, WindowCloseReason closeReason)
		{
		/* --- GHIDRA: HandleOnWindowClosedEvent ---
		void Core_Gameplay_Managers_PopupScheduleManager__HandleOnWindowClosedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (param2 == 4) {
		    Core_Gameplay_Managers_PopupScheduleManager__ScheduleNext(param1,2,4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006965")]
		[Address(RVA = "0xB489", Offset = "0xB489", VA = "0xB489")]
		private void MovCompleteEvent(WorldMovementTypes type)
		{
		/* --- GHIDRA: MovCompleteEvent ---
		void Core_Gameplay_Managers_PopupScheduleManager__MovCompleteEvent
		               (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a63800 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__get_Item__
		              );
		    DAT_ram_00a63800 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar3,iVar6,
		                         Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__get_Item__
		                        );
		      if (((*(uint *)(*(int *)(iVar3 + 8) + 0x14) & param2) == param2) &&
		         (fVar2 = func_ii_7103(*(undefined4 *)(iVar3 + 0x10),0), fVar2 <= 0.0)) {
		        iVar1 = 0;
		        iVar4 = *(int *)(iVar3 + 0xc);
		        if (*(int *)(iVar4 + 0xc) < 1) {
		code_r0x82304311:
		          iVar6 = *(int *)(*(int *)(iVar3 + 8) + 0x10);
		          if (iVar6 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                      (*(undefined4 *)(iVar6 + 0x20),*(undefined4 *)(iVar6 + 0x14));
		          }
		          if (DAT_ram_00a63802 == '\0') {
		            Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		            Mono_Security_ASN1__get_Item
		                      (&
		                       Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__Remove__
		                      );
		            DAT_ram_00a63802 = '\x01';
		          }
		          iVar6 = *(int *)(iVar3 + 8);
		          if (0 < *(int *)(iVar6 + 8)) {
		            *(int *)(iVar6 + 8) = *(int *)(iVar6 + 8) + -1;
		            fVar2 = *(float *)(iVar6 + 0xc);
		            param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		            Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,fVar2,0);
		            *(undefined4 *)(iVar3 + 0x10) = param1_00;
		            return;
		          }
		          func_ii_4876(*(undefined4 *)(param1 + 0x10),iVar3,
		                       Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__Remove__
		                      );
		          return;
		        }
		        while( true ) {
		          iVar5 = *(int *)(iVar4 + iVar1 * 4 + 0x10);
		          iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                            (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar5 + 0x14));
		          if (iVar5 == 0) break;
		          iVar1 = iVar1 + 1;
		          if (*(int *)(iVar4 + 0xc) <= iVar1) goto code_r0x82304311;
		        }
		      }
		      iVar6 = iVar6 + 1;
		      iVar3 = *(int *)(param1 + 0x10);
		    } while (iVar6 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006966")]
		[Address(RVA = "0xB48A", Offset = "0xB48A", VA = "0xB48A")]
		private void OpenFirstAvailableWindow(PopupScheduleManager.Args.TriggeredRights rights)
		{
		/* --- GHIDRA: OpenFirstAvailableWindow ---
		void Core_Gameplay_Managers_PopupScheduleManager__OpenFirstAvailableWindow
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63801 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PopupScheduleManager_ScheduleInfo__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PopupScheduleManager_ScheduleInfo__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_PopupScheduleManager_ScheduleInfo__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__Remove__);
		    DAT_ram_00a63801 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_PopupScheduleManager_ScheduleInfo__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82304615:
		        iVar1 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 == iVar2) {
		          piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		          iVar2 = *piVar3;
		          DAT_ram_009d3e38 = 0;
		          local_18 = iVar2;
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
		        import::env::invoke_ii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0xc,&local_18);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          import::env::__resumeException(param1_00);
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
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		    } while (*(int *)(local_8._4_4_ + 8) != *param2);
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x389,
		                       *(undefined4 *)(param1 + 0x10),local_8._4_4_,
		                       Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__Remove__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82304615;
		    }
		    if (iVar2 != 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x06006967 RID: 26983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006967")]
		public void ScheduleOpenWindow<T>(in PopupScheduleManager.Args args, params Func<bool>[] extraChecks) where T : BaseWindow
		{
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006968")]
		[Address(RVA = "0xB48B", Offset = "0xB48B", VA = "0xB48B")]
		public void UnScheduleOpenWindow(in PopupScheduleManager.Args args)
		{
		/* --- GHIDRA: UnScheduleOpenWindow ---
		void Core_Gameplay_Managers_PopupScheduleManager__UnScheduleOpenWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = Core_Gameplay_Managers_PopupScheduleManager___ctor(param1,param1);
		  if (iVar1 != 0) {
		    Core_Gameplay_Managers_PopupScheduleManager__MovCompleteEvent(param1,param2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006969 RID: 26985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006969")]
		[Address(RVA = "0xB48C", Offset = "0xB48C", VA = "0xB48C")]
		public void OpenNextAvailableWindow(PopupScheduleManager.Args.TriggeredRights rights)
		{
		/* --- GHIDRA: OpenNextAvailableWindow ---
		undefined4
		Core_Gameplay_Managers_PopupScheduleManager__OpenNextAvailableWindow
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  float fVar3;
		  int iVar4;
		  int iVar5;
		  
		  uVar2 = 0;
		  fVar3 = func_ii_7103(*(undefined4 *)(param2 + 0x10),0);
		  if (fVar3 <= 0.0) {
		    uVar2 = 1;
		    iVar4 = *(int *)(param2 + 0xc);
		    if (0 < *(int *)(iVar4 + 0xc)) {
		      iVar1 = 0;
		      do {
		        iVar5 = *(int *)(iVar4 + iVar1 * 4 + 0x10);
		        iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                          (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar5 + 0x14));
		        if (iVar5 == 0) {
		          return 0;
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar4 + 0xc));
		    }
		    iVar4 = *(int *)(*(int *)(param2 + 8) + 0x10);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600696A RID: 26986 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x600696A")]
		[Address(RVA = "0xB48D", Offset = "0xB48D", VA = "0xB48D")]
		private bool TryOpenWindow(PopupScheduleManager.ScheduleInfo info)
		{
		/* --- GHIDRA: TryOpenWindow ---
		void Core_Gameplay_Managers_PopupScheduleManager__TryOpenWindow
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  float param2_00;
		  
		  if (DAT_ram_00a63802 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__Remove__);
		    DAT_ram_00a63802 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 8);
		  if (0 < *(int *)(iVar1 + 8)) {
		    *(int *)(iVar1 + 8) = *(int *)(iVar1 + 8) + -1;
		    param2_00 = *(float *)(iVar1 + 0xc);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		    *(undefined4 *)(param2 + 0x10) = param1_00;
		    return;
		  }
		  func_ii_4876(*(undefined4 *)(param1 + 0x10),param2,
		               Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__Remove__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600696B")]
		[Address(RVA = "0xB48E", Offset = "0xB48E", VA = "0xB48E")]
		private void ScheduleNext(PopupScheduleManager.ScheduleInfo info)
		{
		/* --- GHIDRA: ScheduleNext ---
		void Core_Gameplay_Managers_PopupScheduleManager__ScheduleNext
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63803 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_PopupScheduleManager___c__DisplayClass26_0__OpenNextAvailableWindowDelayed_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_PopupScheduleManager___c__DisplayClass26_0_TypeInfo);
		    DAT_ram_00a63803 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_PopupScheduleManager___c__DisplayClass26_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  if (*(int *)(param1 + 0x14) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x14),0,0);
		  }
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar1,param2_00,
		             Method_Core_Gameplay_Managers_PopupScheduleManager___c__DisplayClass26_0__OpenNextAvailableWindowDelayed_b__0__
		             ,0);
		  uVar1 = DG_Tweening_DOVirtual__EasedValue(0.3,uVar1,1,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600696C RID: 26988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600696C")]
		[Address(RVA = "0xB48F", Offset = "0xB48F", VA = "0xB48F")]
		private void OpenNextAvailableWindowDelayed(PopupScheduleManager.Args.TriggeredRights rights)
		{
		}

		// Token: 0x040037E3 RID: 14307
		[Token(Token = "0x40037E3")]
		private const float DELAY_OPEN = 0.3f;

		// Token: 0x040037E6 RID: 14310
		[Token(Token = "0x40037E6")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<PopupScheduleManager.ScheduleInfo> _scheduledWindows;

		// Token: 0x040037E7 RID: 14311
		[Token(Token = "0x40037E7")]
		[FieldOffset(Offset = "0x14")]
		private Tween _delayTween;

		// Token: 0x040037E8 RID: 14312
		[Token(Token = "0x40037E8")]
		[FieldOffset(Offset = "0x18")]
		private IGame _game;

		// Token: 0x0200116C RID: 4460
		[Token(Token = "0x200116C")]
		public class Args
		{
			// Token: 0x0600696D RID: 26989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600696D")]
			[Address(RVA = "0xB490", Offset = "0xB490", VA = "0xB490")]
			public Args(PopupScheduleManager.Args.TriggeredRights rights)
			{
			}

			// Token: 0x0600696E RID: 26990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600696E")]
			[Address(RVA = "0xB491", Offset = "0xB491", VA = "0xB491")]
			public Args()
			{
			}

			// Token: 0x040037E9 RID: 14313
			[Token(Token = "0x40037E9")]
			[FieldOffset(Offset = "0x8")]
			public int RepeatTimes;

			// Token: 0x040037EA RID: 14314
			[Token(Token = "0x40037EA")]
			[FieldOffset(Offset = "0xC")]
			public float DelaySeconds;

			// Token: 0x040037EB RID: 14315
			[Token(Token = "0x40037EB")]
			[FieldOffset(Offset = "0x10")]
			public Action OpenAction;

			// Token: 0x040037EC RID: 14316
			[Token(Token = "0x40037EC")]
			[FieldOffset(Offset = "0x14")]
			public readonly PopupScheduleManager.Args.TriggeredRights Rights;

			// Token: 0x0200116D RID: 4461
			[Token(Token = "0x200116D")]
			[Flags]
			public enum TriggeredRights
			{
				// Token: 0x040037EE RID: 14318
				[Token(Token = "0x40037EE")]
				None = 0,
				// Token: 0x040037EF RID: 14319
				[Token(Token = "0x40037EF")]
				ForceRun = 1,
				// Token: 0x040037F0 RID: 14320
				[Token(Token = "0x40037F0")]
				WorldMovement = 2,
				// Token: 0x040037F1 RID: 14321
				[Token(Token = "0x40037F1")]
				PopupCountChanged = 4
			}
		}

		// Token: 0x0200116E RID: 4462
		[Token(Token = "0x200116E")]
		private class ScheduleInfo<T> : PopupScheduleManager.ScheduleInfo
		{
			// Token: 0x17001591 RID: 5521
			// (get) Token: 0x0600696F RID: 26991 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001591")]
			public override Type Type
			{
				[Token(Token = "0x600696F")]
				get
				{
					return null;
				}
			}

			// Token: 0x06006970 RID: 26992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006970")]
			public ScheduleInfo(PopupScheduleManager.Args args, Func<bool>[] extraChecks)
			{
			}
		}

		// Token: 0x0200116F RID: 4463
		[Token(Token = "0x200116F")]
		private abstract class ScheduleInfo
		{
			// Token: 0x17001592 RID: 5522
			// (get) Token: 0x06006971 RID: 26993
			[Token(Token = "0x17001592")]
			public abstract Type Type { [Token(Token = "0x6006971")] get; }

			// Token: 0x06006972 RID: 26994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006972")]
			[Address(RVA = "0xB492", Offset = "0xB492", VA = "0xB492")]
			protected ScheduleInfo(PopupScheduleManager.Args args, Func<bool>[] extraChecks)
			{
			}

			// Token: 0x040037F2 RID: 14322
			[Token(Token = "0x40037F2")]
			[FieldOffset(Offset = "0x8")]
			public readonly PopupScheduleManager.Args Args;

			// Token: 0x040037F3 RID: 14323
			[Token(Token = "0x40037F3")]
			[FieldOffset(Offset = "0xC")]
			public readonly Func<bool>[] ExtraChecks;

			// Token: 0x040037F4 RID: 14324
			[Token(Token = "0x40037F4")]
			[FieldOffset(Offset = "0x10")]
			public BackTime BackTime;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_PopupScheduleManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637f7 = '\x01';
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_PopupScheduleManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637f8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_PopupScheduleManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637f9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_PopupScheduleManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637fa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_PopupScheduleManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a637fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__TypeInfo);
		    DAT_ram_00a637fb = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: get_IsPlayerIdle ---
		void Core_Gameplay_Managers_PopupScheduleManager__get_IsPlayerIdle(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a637fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_string__WindowCloseReason__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_PopupScheduleManager_HandleOnWindowClosedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_PopupScheduleManager_MovCompleteEvent__);
		    DAT_ram_00a637fd = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x82303c81;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x82303c81:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 8);
		  uVar8 = *(undefined4 *)(iVar7 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,Method_Core_Gameplay_Managers_PopupScheduleManager_MovCompleteEvent__,0);
		  iVar6 = func_ii_7048(uVar8,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x82303d78;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82303d78:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x82303dfa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x82303dfa:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar8 = unnamed_function_1417(System_Action_string__WindowCloseReason__TypeInfo);
		  System_Action_object__int___Invoke
		            (uVar8,param1,
		             Method_Core_Gameplay_Managers_PopupScheduleManager_HandleOnWindowClosedEvent__,0);
		  UI_Windows_PopupController__add_OnWindowClosedEvent(uVar3,uVar8,0);
		  iVar6 = *(int *)(param1 + 0xc);
		  if (iVar6 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		              (*(undefined4 *)(iVar6 + 0x20),param1,*(undefined4 *)(iVar6 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: ScheduleOpenWindow<object> ---
		void Core_Gameplay_Managers_PopupScheduleManager__ScheduleOpenWindow_object_
		               (undefined8 *param1,undefined4 param2,int param3)
		
		{
		  undefined4 in_register_20000014;
		  int *piVar1;
		  int iVar2;
		  float param2_00;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  double param2_01;
		  undefined4 *puVar5;
		  int param1_00;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int param3_00;
		  
		  puVar5 = *(undefined4 **)(param3 + 0x1c);
		  if (puVar5 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    puVar5 = *(undefined4 **)(param3 + 0x1c);
		    if (puVar5 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      puVar5 = *(undefined4 **)(param3 + 0x1c);
		    }
		  }
		  param3_00 = *(int *)(puVar5[1] + 0x84);
		  param1_00 = (int)&stack0x00000000 - (param3_00 + 0xfU & 0xfffffff0);
		  uVar6 = *puVar5;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  piVar1 = (int *)func_ii_2734(uVar6,0);
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*piVar1 + 0x2f4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x2f0) * 4))(piVar1,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (iVar2 != 0) {
		    uVar4 = CONCAT44(uVar6,*(undefined4 *)
		                            (s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0xc));
		    piVar1 = (int *)(**(code **)((ulonglong)
		                                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 +
		                                          *piVar1 + 8) * 4))(piVar1,uVar4);
		    uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  }
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  iVar2 = System_Reflection_FieldInfo__op_Equality(piVar1,0);
		  if (iVar2 == 3) {
		    uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		    uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		    if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Convert_TypeInfo);
		    }
		    uVar6 = func_ii_11012(uVar6,0);
		    param1[1] = 0;
		    *param1 = 0;
		    UnityEngine_InputSystem_Utilities_PrimitiveValue__get_isEmpty(param1,uVar6,0);
		    return;
		  }
		  if (iVar2 == 4) {
		    uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		    uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		    if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Convert_TypeInfo);
		    }
		    uVar6 = System_Convert__ToBoolean(uVar6,0);
		    param1[1] = 0;
		    *param1 = 0;
		    UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar6,0);
		    return;
		  }
		  if (iVar2 == 5) {
		    uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		    uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		    if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Convert_TypeInfo);
		    }
		    uVar6 = System_Convert__ToChar(uVar6,0);
		    param1[1] = 0;
		    *param1 = 0;
		    UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar6,0);
		    return;
		  }
		  if (iVar2 == 6) {
		    uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		    uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		    if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Convert_TypeInfo);
		    }
		    uVar6 = System_Convert__ToSByte(uVar6,0);
		    param1[1] = 0;
		    *param1 = 0;
		    UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar6,0);
		    return;
		  }
		  if (iVar2 == 7) {
		    uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		    uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		    if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Convert_TypeInfo);
		    }
		    uVar6 = System_Convert__ToByte(uVar6,0);
		    param1[1] = 0;
		    *param1 = 0;
		    UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar6,0);
		    return;
		  }
		  if (iVar2 == 8) {
		    uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		    uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		    if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Convert_TypeInfo);
		    }
		    uVar6 = System_Convert__ToInt16(uVar6,0);
		    param1[1] = 0;
		    *param1 = 0;
		    UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar6,0);
		    return;
		  }
		  if (iVar2 != 9) {
		    if (iVar2 == 10) {
		      uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		      uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		      if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Convert_TypeInfo);
		      }
		      uVar6 = System_Convert__ToInt32(uVar6,0);
		      param1[1] = 0;
		      *param1 = 0;
		      UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar6,0);
		      return;
		    }
		    if (iVar2 == 0xb) {
		      uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		      uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		      if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Convert_TypeInfo);
		      }
		      uVar4 = System_Convert__ToUInt32(uVar6,0);
		      param1[1] = 0;
		      *param1 = 0;
		      UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar4,0);
		      return;
		    }
		    if (iVar2 == 0xc) {
		      uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		      uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		      if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Convert_TypeInfo);
		      }
		      uVar4 = func_ii_16871(uVar6,0);
		      param1[1] = 0;
		      *param1 = 0;
		      UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar4,0);
		      return;
		    }
		    if (iVar2 != 0xd) {
		      if (iVar2 != 0xe) {
		        uVar3 = unnamed_function_713(param1_00,param2,param3_00);
		        uVar3 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar3);
		        uVar7 = **(undefined4 **)(param3 + 0x1c);
		        unnamed_function_151018(DAT_ram_00a669a0);
		        piVar1 = (int *)func_ii_2734(uVar7,0);
		        uVar6 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                          (piVar1,CONCAT44(uVar6,*(undefined4 *)(*piVar1 + 0x104)));
		        uVar7 = unnamed_function_2232(&StringLiteral_4765);
		        uVar6 = System_Collections_Generic_Dictionary_int__object___ContainsKey(uVar7,uVar3,uVar6,0)
		        ;
		        uVar3 = unnamed_function_2232(&System_ArgumentException_TypeInfo);
		        uVar3 = unnamed_function_1417(uVar3);
		        uVar7 = unnamed_function_2232(&StringLiteral_28217);
		        System_IO_EndOfStreamException___ctor(uVar3,uVar6,uVar7,0);
		        func_ii_1050(uVar3,param3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		      uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		      if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Convert_TypeInfo);
		      }
		      param2_01 = System_Convert__ToSingle(uVar6,0);
		      param1[1] = 0;
		      *param1 = 0;
		      UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,param2_01,0);
		      return;
		    }
		    uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		    uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		    if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Convert_TypeInfo);
		    }
		    param2_00 = System_Convert__ToUInt64(uVar6,0);
		    param1[1] = 0;
		    *param1 = 0;
		    UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,param2_00,0);
		    return;
		  }
		  uVar6 = unnamed_function_713(param1_00,param2,param3_00);
		  uVar6 = func_ii_1081(*(undefined4 *)(*(int *)(param3 + 0x1c) + 4),uVar6);
		  if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Convert_TypeInfo);
		  }
		  uVar6 = System_Convert__ToUInt16(uVar6,0);
		  param1[1] = 0;
		  *param1 = 0;
		  UnityEngine_InputSystem_Utilities_PrimitiveValue___ctor(param1,uVar6,0);
		  return;
		}
		*/

}
