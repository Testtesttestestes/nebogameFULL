using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers;
using Core.Gameplay;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Gameplay.FeedbackForm.Model.Source
{
	// Token: 0x02000826 RID: 2086
	[Token(Token = "0x2000826")]
	public class LoadScreenSource : IFeedbackFormSource, IDisposable
	{
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009A8")]
		public Themes[] Themes
		{
			[Token(Token = "0x600311B")]
			[Address(RVA = "0x8174", Offset = "0x8174", VA = "0x8174", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x170009A9")]
		public Themes DefaultTheme
		{
			[Token(Token = "0x600311C")]
			[Address(RVA = "0x8175", Offset = "0x8175", VA = "0x8175", Slot = "5")]
			get
			{
				return Gameplay.FeedbackForm.Model.Themes.UNKNOWN;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x170009AA")]
		public uint RequiredFormFields
		{
			[Token(Token = "0x600311D")]
			[Address(RVA = "0x8176", Offset = "0x8176", VA = "0x8176", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009AB")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x600311E")]
			[Address(RVA = "0x8177", Offset = "0x8177", VA = "0x8177", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AC")]
		public IPlatformSigninProvider SigninProvider
		{
			[Token(Token = "0x600311F")]
			[Address(RVA = "0x8178", Offset = "0x8178", VA = "0x8178", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003120")]
			[Address(RVA = "0x8179", Offset = "0x8179", VA = "0x8179")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AD")]
		public IAuthDataProvider AuthDataProvider
		{
			[Token(Token = "0x6003121")]
			[Address(RVA = "0x817A", Offset = "0x817A", VA = "0x817A", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003122")]
			[Address(RVA = "0x817B", Offset = "0x817B", VA = "0x817B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009AE")]
		public IClientVersionProvider ClientVersionProvider
		{
			[Token(Token = "0x6003123")]
			[Address(RVA = "0x817C", Offset = "0x817C", VA = "0x817C", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009AF")]
		public Uri Endpoint
		{
			[Token(Token = "0x6003124")]
			[Address(RVA = "0x817D", Offset = "0x817D", VA = "0x817D", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x817E", Offset = "0x817E", VA = "0x817E", Slot = "12")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_FeedbackForm_Model_Source_LoadScreenSource__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int param1_00;
		  
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  param1_00 = param1 + 8;
		  Core_Extensions_TransformExt__SetBottom(param1_00,2,0);
		  Core_Extensions_TransformExt__SetBottom(param1_00,4,0);
		  Core_Extensions_TransformExt__SetBottom(param1_00,8,0);
		  return;
		}
		*/

		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x817F", Offset = "0x817F", VA = "0x817F")]
		private LoadScreenSource(IPlatformConfigurationProvider cfgProvider, IClientVersionProvider clientVersionProvider, Uri endpoint)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_FeedbackForm_Model_Source_LoadScreenSource___ctor
		              (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *param2_00;
		  uint *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *param2_01;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a57605 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_LoadScreenSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a57605 = '\x01';
		  }
		  iVar7 = *param1;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (undefined4 *)
		                 (*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x110);
		        goto code_r0x80db4765;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param1,
		                      Core_Application_IApp_TypeInfo,10);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80db48f2:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x80db4765:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,param1,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80db48f2;
		    param2_01 = *(int **)(iVar7 + 0x10);
		    iVar7 = *param2_01;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (undefined4 *)
		                   (*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		          goto code_r0x80db483f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2_01,
		                        Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                        ,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80db48fc:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		code_r0x80db483f:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar2,param2_01,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80db48fc;
		      uVar8 = *(undefined4 *)(iVar7 + 0x20);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,System_Uri_TypeInfo
		                        );
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x31e,uVar3,uVar8,0);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          iVar7 = *param1;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		                puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 +
		                                 0x110);
		                goto code_r0x80db4a70;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          puVar5 = (uint *)func_ii_1080(param1,Core_Application_IApp_TypeInfo,10);
		code_r0x80db4a70:
		          iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(param1,puVar5[1]);
		          uVar8 = *(undefined4 *)(iVar7 + 0x10);
		          uVar1 = 0;
		          iVar7 = *param1;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            do {
		              if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		                puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 +
		                                 0x118);
		                goto code_r0x80db4aef;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          puVar5 = (uint *)func_ii_1080(param1,Core_Application_IApp_TypeInfo,0xb);
		code_r0x80db4aef:
		          uVar1 = 0;
		          uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(param1,puVar5[1]);
		          iVar7 = unnamed_function_1417
		                            (Gameplay_FeedbackForm_Model_Source_LoadScreenSource_TypeInfo);
		          *(undefined4 *)(iVar7 + 0x1c) = uVar3;
		          *(undefined4 *)(iVar7 + 0xc) = uVar8;
		          *(undefined4 *)(iVar7 + 0x18) = uVar6;
		          iVar4 = iVar7 + 8;
		          Core_Extensions_TransformExt__SetBottom(iVar4,2,0);
		          Core_Extensions_TransformExt__SetBottom(iVar4,4,0);
		          Core_Extensions_TransformExt__SetBottom(iVar4,8,0);
		          iVar4 = *param1;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            do {
		              if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 +
		                                 0x128);
		                goto code_r0x80db4bb4;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          puVar5 = (uint *)func_ii_1080(param1,Core_Application_IApp_TypeInfo,0xd);
		code_r0x80db4bb4:
		          iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(param1,puVar5[1]);
		          uVar3 = *(undefined4 *)(iVar4 + 0xc);
		          *(undefined4 *)(iVar7 + 0x14) = param2;
		          *(undefined4 *)(iVar7 + 0x10) = uVar3;
		          return iVar7;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    puVar2 = (undefined4 *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_UriFormatException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*puVar2);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        if (iVar4 != 0) {
		          uVar3 = *puVar2;
		          import::env::__cxa_end_catch();
		          System_Data_DataSet__ValidateLocaleConstraint(uVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar2;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80db4be1;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x80db4be1:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x8180", Offset = "0x8180", VA = "0x8180")]
		public static IFeedbackFormSource Create(IApp app, [CanBeNull] IAuthDataProvider authDataProvider)
		{
		/* --- GHIDRA: Create ---
		void Gameplay_FeedbackForm_Model_Source_LoadScreenSource__Create(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57606 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_FeedbackFormModel__FeedbackFormEvents__Dispose__);
		    DAT_ram_00a57606 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_FeedbackFormModel__FeedbackFormEvents__Dispose__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x8")]
		private uint _requiredFormFields;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Endpoint ---
		void Gameplay_FeedbackForm_Model_Source_LoadScreenSource__get_Endpoint
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&Method_Gameplay_FeedbackForm_Model_Source_LoadScreenSource_Dispose__);
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
