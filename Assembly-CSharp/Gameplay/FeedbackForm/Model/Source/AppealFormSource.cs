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
	// Token: 0x02000823 RID: 2083
	[Token(Token = "0x2000823")]
	public class AppealFormSource : IFeedbackFormSource, IDisposable
	{
		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000990")]
		public Themes[] Themes
		{
			[Token(Token = "0x60030F9")]
			[Address(RVA = "0x815A", Offset = "0x815A", VA = "0x815A", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x17000991")]
		public Themes DefaultTheme
		{
			[Token(Token = "0x60030FA")]
			[Address(RVA = "0x815B", Offset = "0x815B", VA = "0x815B", Slot = "5")]
			get
			{
				return Gameplay.FeedbackForm.Model.Themes.UNKNOWN;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x17000992")]
		public uint RequiredFormFields
		{
			[Token(Token = "0x60030FB")]
			[Address(RVA = "0x815C", Offset = "0x815C", VA = "0x815C", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000993")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x60030FC")]
			[Address(RVA = "0x815D", Offset = "0x815D", VA = "0x815D", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000994")]
		public IPlatformSigninProvider SigninProvider
		{
			[Token(Token = "0x60030FD")]
			[Address(RVA = "0x815E", Offset = "0x815E", VA = "0x815E", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030FE")]
			[Address(RVA = "0x815F", Offset = "0x815F", VA = "0x815F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000995")]
		public IAuthDataProvider AuthDataProvider
		{
			[Token(Token = "0x60030FF")]
			[Address(RVA = "0x8160", Offset = "0x8160", VA = "0x8160", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003100")]
			[Address(RVA = "0x8161", Offset = "0x8161", VA = "0x8161")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000996")]
		public IClientVersionProvider ClientVersionProvider
		{
			[Token(Token = "0x6003101")]
			[Address(RVA = "0x8162", Offset = "0x8162", VA = "0x8162", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000997")]
		public Uri Endpoint
		{
			[Token(Token = "0x6003102")]
			[Address(RVA = "0x8163", Offset = "0x8163", VA = "0x8163", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x8164", Offset = "0x8164", VA = "0x8164", Slot = "12")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_FeedbackForm_Model_Source_AppealFormSource__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int param1_00;
		  
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  param1_00 = param1 + 8;
		  Core_Extensions_TransformExt__SetBottom(param1_00,8,0);
		  Core_Extensions_TransformExt__SetBottom(param1_00,2,0);
		  Core_Extensions_TransformExt__SetBottom(param1_00,4,0);
		  Core_Extensions_TransformExt__SetBottom(param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x8165", Offset = "0x8165", VA = "0x8165")]
		public AppealFormSource(IPlatformConfigurationProvider cfgProvider, IClientVersionProvider clientVersionProvider, Uri endpoint)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_FeedbackForm_Model_Source_AppealFormSource___ctor
		              (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  int *param1_01;
		  undefined4 param2_00;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57601 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_AppealFormSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a57601 = '\x01';
		  }
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80db56de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Application_IApp_TypeInfo,10);
		code_r0x80db56de:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = *(undefined4 *)(iVar6 + 0x10);
		  uVar1 = 0;
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x118);
		        goto code_r0x80db575d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Application_IApp_TypeInfo,0xb);
		code_r0x80db575d:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80db57df;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Application_IApp_TypeInfo,10);
		code_r0x80db57df:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar1 = 0;
		  param1_01 = *(int **)(iVar6 + 0x10);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80db5860;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,1);
		code_r0x80db5860:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param2_00 = *(undefined4 *)(iVar6 + 0x20);
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(param1_00,param2_00,0);
		  iVar6 = unnamed_function_1417(Gameplay_FeedbackForm_Model_Source_AppealFormSource_TypeInfo);
		  *(undefined4 *)(iVar6 + 0x1c) = param1_00;
		  *(undefined4 *)(iVar6 + 0xc) = uVar4;
		  *(undefined4 *)(iVar6 + 0x18) = uVar3;
		  iVar5 = iVar6 + 8;
		  Core_Extensions_TransformExt__SetBottom(iVar5,8,0);
		  Core_Extensions_TransformExt__SetBottom(iVar5,2,0);
		  Core_Extensions_TransformExt__SetBottom(iVar5,4,0);
		  Core_Extensions_TransformExt__SetBottom(iVar5,1,0);
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x128);
		        goto code_r0x80db5947;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Application_IApp_TypeInfo,0xd);
		code_r0x80db5947:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = *(undefined4 *)(iVar5 + 0xc);
		  *(undefined4 *)(iVar6 + 0x14) = param2;
		  *(undefined4 *)(iVar6 + 0x10) = uVar4;
		  return iVar6;
		}
		*/

		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003105")]
		[Address(RVA = "0x8166", Offset = "0x8166", VA = "0x8166")]
		public static IFeedbackFormSource Create(IApp app, [CanBeNull] IAuthDataProvider authDataProvider)
		{
			return null;
		}

		// Token: 0x04001AD0 RID: 6864
		[Token(Token = "0x4001AD0")]
		[FieldOffset(Offset = "0x8")]
		private uint _requiredFormFields;
	}
}
