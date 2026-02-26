using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Combat;
using Protocol.Dic;
using Protocol.Partycombat;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Colossus.Combat
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	public class ColossusCombatLauncher : IDisposable, IColossusCombatLauncher
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00004A28 File Offset: 0x00002C28
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002ED")]
		public bool IsRun
		{
			[Token(Token = "0x60012ED")]
			[Address(RVA = "0x64E7", Offset = "0x64E7", VA = "0x64E7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60012EE")]
			[Address(RVA = "0x64E8", Offset = "0x64E8", VA = "0x64E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x64E9", Offset = "0x64E9", VA = "0x64E9")]
		public ColossusCombatLauncher(IGame game, PartyCombatService service)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58c13 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJumpToCombatEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_HandleJumpToCombatEvent__
		              );
		    DAT_ram_00a58c13 = '\x01';
		  }
		  if (*(char *)(param1 + 0x14) != '\0') {
		    uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_3029);
		    System_String__Concat(uVar1,uVar2,0);
		    uVar2 = unnamed_function_2232
		                      (&Method_Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_Run__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = unnamed_function_1417(System_Action_ProtoJumpToCombatEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_HandleJumpToCombatEvent__
		             ,0);
		  ServicesNamespace_ColossusService___ctor(uVar2,uVar1,0);
		  *(undefined1 *)(param1 + 0x14) = 1;
		  return;
		}
		*/

		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x64EA", Offset = "0x64EA", VA = "0x64EA")]
		public void Run()
		{
		/* --- GHIDRA: Run ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__Run(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58c14 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoJumpToCombatEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_HandleJumpToCombatEvent__
		              );
		    DAT_ram_00a58c14 = '\x01';
		  }
		  if (*(char *)(param1 + 0x14) == '\0') {
		    uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_11613);
		    System_String__Concat(uVar1,uVar2,0);
		    uVar2 = unnamed_function_2232
		                      (&Method_Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_Stop__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = unnamed_function_1417(System_Action_ProtoJumpToCombatEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_HandleJumpToCombatEvent__
		             ,0);
		  ServicesNamespace_CombatService__add_JumpToCombatEvent(uVar2,uVar1,0);
		  *(undefined1 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x64EB", Offset = "0x64EB", VA = "0x64EB")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__Stop(int param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__Run(param1,param1);
		  Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__Dispose(param1,0,param1);
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x64EC", Offset = "0x64EC", VA = "0x64EC", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__Dispose
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58c15 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_HandleCombatCompleteEvent__
		              );
		    DAT_ram_00a58c15 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x10) == 0) ||
		     (iVar1 = Google_Protobuf_Reflection_EnumDescriptorProto_Types_EnumReservedRange__Equals
		                        (*(int *)(param1 + 0x10),param2,0), iVar1 == 0)) {
		    *(int *)(param1 + 0x10) = param2;
		    param1_01 = *(undefined4 *)(param1 + 0xc);
		    param1_00 = unnamed_function_1417(System_Action_ProtoCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_HandleCombatCompleteEvent__
		               ,0);
		    if (param2 == 0) {
		      ServicesNamespace_PartyCombatService__add_CombatCompleteEvent(param1_01,param1_00,0);
		      return;
		    }
		    ServicesNamespace_PartyCombatService__remove_FieldChangedEvent(param1_01,param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x64ED", Offset = "0x64ED", VA = "0x64ED")]
		private void SetAwaitJumpToCombat(ProtoJumpToCombatEvt value)
		{
		/* --- GHIDRA: SetAwaitJumpToCombat ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__SetAwaitJumpToCombat
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__Dispose(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x64EE", Offset = "0x64EE", VA = "0x64EE")]
		private void HandleCombatCompleteEvent(Protocol.Partycombat.ProtoCombatCompleteEvt msg)
		{
		/* --- GHIDRA: HandleCombatCompleteEvent ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__HandleCombatCompleteEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58c16 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58c16 = '\x01';
		  }
		  if (*(int *)(param2 + 0x10) == 0xb) {
		    uVar1 = 0;
		    piVar3 = *(int **)(param1 + 8);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x218);
		          goto code_r0x80f8b542;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80f8b542:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f8b5c6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x80f8b5c6:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar4 == 0) {
		code_r0x80f8b891:
		      Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__HandleJumpToCombatEvent
		                (param1,0,0,puVar2);
		      return;
		    }
		    uVar1 = 0;
		    piVar3 = *(int **)(param1 + 8);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x218);
		          goto code_r0x80f8b647;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80f8b647:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f8b6c9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x80f8b6c9:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (piVar3 == (int *)0x0) {
		      puVar2 = (uint *)0x0;
		    }
		    else {
		      puVar2 = (uint *)*piVar3;
		      if (((uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo + 0xb8) <=
		           (uint)(byte)puVar2[0x2e]) &&
		         (*(int *)(puVar2[0x19] +
		                   (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo + 0xb8
		                                  ) * 4 + -4) ==
		          Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo)) {
		        uVar1 = 0;
		        piVar3 = *(int **)(param1 + 8);
		        iVar4 = *piVar3;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x218
		                               );
		              goto code_r0x80f8b781;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x80f8b781:
		        piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		        uVar1 = 0;
		        iVar4 = *piVar3;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		                *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f8b803;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x80f8b803:
		        piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		        uVar1 = 0;
		        iVar4 = *piVar3;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f8b881;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_ICombat_TypeInfo,0);
		code_r0x80f8b881:
		        iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		        if (iVar4 == 0) goto code_r0x80f8b891;
		      }
		    }
		    Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__Dispose(param1,param2,puVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x64EF", Offset = "0x64EF", VA = "0x64EF")]
		private void HandleJumpToCombatEvent(ProtoJumpToCombatEvt msg)
		{
		/* --- GHIDRA: HandleJumpToCombatEvent ---
		int Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__HandleJumpToCombatEvent
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58c17 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatRewards_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_LaunchParams_TypeInfo);
		    DAT_ram_00a58c17 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 8);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f8b969;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f8b969:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = func_ii_7112(uVar3,0);
		  piVar4 = *(int **)(param1 + 8);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80f8b9f4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f8b9f4:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatRewards_TypeInfo);
		  Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatRewards__get_CombatWinReward
		            (param1_00,uVar3,uVar3);
		  iVar6 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_LaunchParams_TypeInfo);
		  *(undefined4 *)(iVar6 + 0x10) = param2;
		  *(undefined4 *)(iVar6 + 8) = param1_00;
		  *(int *)(iVar6 + 0xc) = param1;
		  uVar3 = *(undefined4 *)(param1 + 8);
		  piVar4 = (int *)unnamed_function_1417(Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo);
		  if (DAT_ram_00a58c11 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView___ctor__
		              );
		    DAT_ram_00a58c11 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (piVar4,uVar3,iVar5,iVar5,param3,
		             Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView___ctor__
		            );
		  piVar4[0xc] = iVar6;
		  iVar5 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___TryRun
		                    (piVar4,*(undefined4 *)(*(int *)(iVar5 + 0x6c) + 0x2c),
		                     Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__TryRun__
		                    );
		  if (iVar5 == 0) {
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		              (piVar4,
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__Stop__
		              );
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x118) * 4))
		              (piVar4,*(undefined4 *)(*piVar4 + 0x11c));
		  }
		  return iVar5;
		}
		*/

		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x64F0", Offset = "0x64F0", VA = "0x64F0")]
		private bool TryRun_Internal([CanBeNull] ColossusDic colossus, [CanBeNull] BackTime backTime)
		{
		/* --- GHIDRA: TryRun_Internal ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__TryRun_Internal
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x10) != 0) {
		    Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__HandleCombatCompleteEvent
		              (param1,*(int *)(param1 + 0x10),param1);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x64F1", Offset = "0x64F1", VA = "0x64F1", Slot = "5")]
		public void NotifyAboutStop()
		{
		/* --- GHIDRA: NotifyAboutStop ---
		undefined4
		Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__NotifyAboutStop
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__HandleJumpToCombatEvent
		                    (param1,0,0,param1);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x64F2", Offset = "0x64F2", VA = "0x64F2", Slot = "6")]
		public bool TryRun()
		{
		/* --- GHIDRA: TryRun ---
		undefined4
		Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__TryRun
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__HandleJumpToCombatEvent
		                    (param1,param2,0,param2);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: TryRun ---
		undefined4
		Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__TryRun
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__HandleJumpToCombatEvent
		                    (param1,param2,0,param2);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: TryRun ---
		undefined4
		Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__TryRun
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__HandleJumpToCombatEvent
		                    (param1,param2,0,param2);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x64F3", Offset = "0x64F3", VA = "0x64F3", Slot = "7")]
		public bool TryRun(BackTime backTime)
		{
			return default(bool);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x64F4", Offset = "0x64F4", VA = "0x64F4", Slot = "8")]
		public bool TryRun(ColossusDic colossus)
		{
			return default(bool);
		}

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x8")]
		private IGame _game;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0xC")]
		private PartyCombatService _service;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0x10")]
		private ProtoJumpToCombatEvt _jumpToCombatMsg;
	}
}
