using System;
using System.Runtime.CompilerServices;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game
{
	// Token: 0x020011C9 RID: 4553
	[Token(Token = "0x20011C9")]
	public class DefaultGameLocator : ILocator, IDisposable
	{
		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06006C7B RID: 27771 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C7C RID: 27772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700162A")]
		public IGame Game
		{
			[Token(Token = "0x6006C7B")]
			[Address(RVA = "0xB767", Offset = "0xB767", VA = "0xB767")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C7C")]
			[Address(RVA = "0xB768", Offset = "0xB768", VA = "0xB768")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06006C7D RID: 27773 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C7E RID: 27774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700162B")]
		public IPathNodeFactoryRepository PathNodeFactoryRepository
		{
			[Token(Token = "0x6006C7D")]
			[Address(RVA = "0xB769", Offset = "0xB769", VA = "0xB769")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C7E")]
			[Address(RVA = "0xB76A", Offset = "0xB76A", VA = "0xB76A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C7F")]
		[Address(RVA = "0xB76B", Offset = "0xB76B", VA = "0xB76B", Slot = "7")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a700 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_OpTokenRepository_TypeInfo);
		    DAT_ram_00a5a700 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_OpTokenRepository_TypeInfo);
		  Utils_OpTokenRepository__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C80")]
		[Address(RVA = "0xB76C", Offset = "0xB76C", VA = "0xB76C")]
		public DefaultGameLocator(IGame game, IPathNodeFactoryRepository repository)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator___ctor
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a701 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27696);
		    DAT_ram_00a5a701 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(iVar1 + 0x10) = StringLiteral_27696;
		  return iVar1;
		}
		*/

		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700162C")]
		public string[] Schemes
		{
			[Token(Token = "0x6006C81")]
			[Address(RVA = "0xB76D", Offset = "0xB76D", VA = "0xB76D", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06006C82 RID: 27778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700162D")]
		public string Host
		{
			[Token(Token = "0x6006C82")]
			[Address(RVA = "0xB76E", Offset = "0xB76E", VA = "0xB76E", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C83")]
		[Address(RVA = "0xB76F", Offset = "0xB76F", VA = "0xB76F")]
		private void ApplyCommonArgs(LocatorPayload payload)
		{
		/* --- GHIDRA: ApplyCommonArgs ---
		int Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator__ApplyCommonArgs
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5a703 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Rounting_LocatorPayload_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_Path_TypeInfo);
		    DAT_ram_00a5a703 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = *(undefined4 *)(param1 + 8);
		  uVar4 = *(undefined4 *)(param1 + 0xc);
		  param1_00 = unnamed_function_1417(Core_Rounting_Path_TypeInfo);
		  Core_Rounting_Path__Dispose(param1_00,uVar4,uVar3,uVar2,param2,0);
		  iVar1 = Core_Rounting_Path___ctor(param1_00,0);
		  if (iVar1 != 0) {
		    uVar2 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___ConfigurationManager__HandleConfigurationProvider_d__19_
		                      (param2,0);
		    uVar3 = System_Uri__get_Query(param2,0);
		    uVar4 = unnamed_function_1417(Core_Rounting_LocatorPayload_TypeInfo);
		    UnityEngine_Purchasing_Default_Factory__Create(uVar4,uVar2,uVar3,0);
		    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator__get_Host
		              (param1,uVar4,param1);
		    Core_Rounting_Path__Check(param1_00,0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x00014040 File Offset: 0x00012240
		[Token(Token = "0x6006C84")]
		[Address(RVA = "0xB770", Offset = "0xB770", VA = "0xB770", Slot = "6")]
		public bool TryExecute(Uri uri)
		{
		/* --- GHIDRA: TryExecute ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator__TryExecute
		          (undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a704 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14086);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1253);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a5a704 = '\x01';
		  }
		  if (DAT_ram_00a5a701 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27696);
		    DAT_ram_00a5a701 = '\x01';
		  }
		  param2_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(param2_00 + 0x10) = StringLiteral_27696;
		  uVar1 = UnityEngine_Assertions_Assert__IsFalse(StringLiteral_1236,param2_00,0);
		  uVar1 = System_Int32__ToString
		                    (StringLiteral_14086,uVar1,StringLiteral_1253,
		                     **(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006C85")]
		[Address(RVA = "0xB771", Offset = "0xB771", VA = "0xB771", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator__ToString
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a705 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Fail__);
		    DAT_ram_00a5a705 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x8125f138;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125f138:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar3 = Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),2,
		                     Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		                    );
		  if (iVar3 != 0) {
		    Core_ExternAppMethods__OpenPaymentWindow
		              (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		    return;
		  }
		  Utils_OpToken_object__object___DisposeHandlers
		            (param3,param1,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Fail__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04003905 RID: 14597
		[Token(Token = "0x4003905")]
		[FieldOffset(Offset = "0x8")]
		private OpTokenRepository _tokenRepository;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_PathNodeFactoryRepository ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator__set_PathNodeFactoryRepository
		               (int param1,undefined4 param2)
		
		{
		  Utils_OpTokenRepository__Remove(*(undefined4 *)(param1 + 8),0);
		  Utils_OpToken__Cancel(*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_Host ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_DefaultGameLocator__get_Host
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  uint *puVar6;
		  int *piVar7;
		  uint uVar8;
		  int local_38;
		  undefined1 *puStack_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined1 local_20 [8];
		  undefined4 local_18;
		  undefined4 uStack_14;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a702 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__string__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28362);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26431);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27883);
		    DAT_ram_00a5a702 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_38,*(undefined4 *)(param2 + 8),
		             Method_System_Collections_Generic_Dictionary_string__string__GetEnumerator__);
		  local_10 = (undefined4)local_28;
		  uStack_c = (undefined4)((ulonglong)local_28 >> 0x20);
		  local_18 = (undefined4)local_30;
		  uStack_14 = (undefined4)((ulonglong)local_30 >> 0x20);
		  local_38 = 0;
		  puStack_34 = local_20;
		  do {
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,local_20,
		                           Method_System_Collections_Generic_Dictionary_Enumerator_string__string__MoveNext__
		                          );
		        uVar3 = local_10;
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8125edd5;
		        }
		        if (iVar1 == 0) goto code_r0x8125ee2b;
		        DAT_ram_009d3e38 = 0;
		        iVar1 = System_Collections_CollectionBase___ctor(uStack_14,StringLiteral_28362,0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8125edd5;
		        }
		      } while (iVar1 == 0);
		      DAT_ram_009d3e38 = 0;
		      iVar1 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_26431,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8125edd5;
		      }
		    } while (iVar1 == 0);
		    piVar4 = *(int **)(param1 + 0xc);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(piVar7[1] * 8 + iVar5 + 0xe0);
		          goto code_r0x8125ec58;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        Core_Gameplay_IGame_TypeInfo,4);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8125eda5:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125edd5;
		    }
		code_r0x8125ec58:
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8125eda5;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8);
		        if (Core_Application_IApp_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(piVar7[1] * 8 + iVar5 + 0xe8);
		          goto code_r0x8125ed29;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        Core_Application_IApp_TypeInfo,5);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x8125ed29:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32e,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8125edd5:
		  iVar5 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar1) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_38 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8125ee2b:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = Core_Rounting_LocatorPayload__TryGetRequiredArgValue
		                        (param2,StringLiteral_27883,&local_4,0);
		      if ((iVar5 != 0) && (iVar5 = System_UInt32__Parse(local_4,&local_8,0), iVar5 != 0)) {
		        uVar8 = 0;
		        piVar4 = *(int **)(param1 + 0xc);
		        iVar5 = *piVar4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		              puVar6 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0x1e8
		                               );
		              goto code_r0x8125ef03;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x8125ef03:
		        iVar5 = (**(code **)((ulonglong)*puVar6 * 4))(piVar4,puVar6[1]);
		        Gameplay_Tutorial_Guide_Control_GuideController__HandleStop
		                  (*(undefined4 *)(iVar5 + 0x10),local_8,0);
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32f,&local_38);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 != 1) {
		    import::env::__resumeException(uVar3);
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
		*/

}
