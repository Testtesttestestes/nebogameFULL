using System;
using System.Runtime.CompilerServices;
using Core.Application.Managers;
using Core.Gameplay;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Gameplay.FeedbackForm.Model.Source
{
	// Token: 0x02000824 RID: 2084
	[Token(Token = "0x2000824")]
	public class DefaultSource : IFeedbackFormSource, IDisposable
	{
		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000998")]
		public Themes[] Themes
		{
			[Token(Token = "0x6003106")]
			[Address(RVA = "0x8167", Offset = "0x8167", VA = "0x8167", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x17000999")]
		public Themes DefaultTheme
		{
			[Token(Token = "0x6003107")]
			[Address(RVA = "0x8168", Offset = "0x8168", VA = "0x8168", Slot = "5")]
			get
			{
				return Gameplay.FeedbackForm.Model.Themes.UNKNOWN;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x1700099A")]
		public uint RequiredFormFields
		{
			[Token(Token = "0x6003108")]
			[Address(RVA = "0x8169", Offset = "0x8169", VA = "0x8169", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700099B")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x6003109")]
			[Address(RVA = "0x816A", Offset = "0x816A", VA = "0x816A", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099C")]
		public IPlatformSigninProvider SigninProvider
		{
			[Token(Token = "0x600310A")]
			[Address(RVA = "0x816B", Offset = "0x816B", VA = "0x816B", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600310B")]
			[Address(RVA = "0x816C", Offset = "0x816C", VA = "0x816C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099D")]
		public IAuthDataProvider AuthDataProvider
		{
			[Token(Token = "0x600310C")]
			[Address(RVA = "0x816D", Offset = "0x816D", VA = "0x816D", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600310D")]
			[Address(RVA = "0x816E", Offset = "0x816E", VA = "0x816E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700099E")]
		public IClientVersionProvider ClientVersionProvider
		{
			[Token(Token = "0x600310E")]
			[Address(RVA = "0x816F", Offset = "0x816F", VA = "0x816F", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700099F")]
		public Uri Endpoint
		{
			[Token(Token = "0x600310F")]
			[Address(RVA = "0x8170", Offset = "0x8170", VA = "0x8170", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003110")]
		[Address(RVA = "0x8171", Offset = "0x8171", VA = "0x8171", Slot = "12")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_FeedbackForm_Model_Source_DefaultSource__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57602 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Themes___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__A5FEAA81797B87F7B1F53F4D2173ED8CA2165B04D387B698B7FB3DEE9643AF7C
		              );
		    DAT_ram_00a57602 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x20) = param4;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  param1_00 = Mono_Security_ASN1Convert__ToOid(Gameplay_FeedbackForm_Model_Themes___TypeInfo,6);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_00,
		             Field__PrivateImplementationDetails__A5FEAA81797B87F7B1F53F4D2173ED8CA2165B04D387B698B7FB3DEE9643AF7C
		             ,0);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  param1_01 = param1 + 0xc;
		  Core_Extensions_TransformExt__SetBottom(param1_01,1,0);
		  Core_Extensions_TransformExt__SetBottom(param1_01,2,0);
		  Core_Extensions_TransformExt__SetBottom(param1_01,4,0);
		  Core_Extensions_TransformExt__SetBottom(param1_01,8,0);
		  return;
		}
		*/

		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003111")]
		[Address(RVA = "0x8172", Offset = "0x8172", VA = "0x8172")]
		private DefaultSource(IPlatformConfigurationProvider cfgProvider, IClientVersionProvider clientVersionProvider, Uri endpoint)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_FeedbackForm_Model_Source_DefaultSource___ctor
		              (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 param3_00;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57603 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Source_DefaultSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20781);
		    DAT_ram_00a57603 = '\x01';
		  }
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x80db5aac;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80db5aac:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80db5b2a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,10);
		code_r0x80db5b2a:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar6 + 0x10);
		  uVar1 = 0;
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x80db5bab;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80db5bab:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar1 = 0;
		  iVar6 = *piVar3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x118);
		        goto code_r0x80db5c27;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xb);
		code_r0x80db5c27:
		  uVar1 = 0;
		  param3_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80db5ca9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80db5ca9:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar4,StringLiteral_20781,0);
		  param1_00 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(param1_00,uVar4,0);
		  iVar6 = unnamed_function_1417(Gameplay_FeedbackForm_Model_Source_DefaultSource_TypeInfo);
		  uVar1 = 0;
		  Gameplay_FeedbackForm_Model_Source_DefaultSource__Dispose(iVar6,uVar5,param3_00,param1_00,0);
		  iVar7 = *param1;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80db5d67;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80db5d67:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar1 = 0;
		  iVar7 = *piVar3;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x128);
		        goto code_r0x80db5de5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xd);
		code_r0x80db5de5:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar7 + 0xc);
		  *(undefined4 *)(iVar6 + 0x18) = param2;
		  *(undefined4 *)(iVar6 + 0x14) = uVar5;
		  return iVar6;
		}
		*/

		}

		// Token: 0x06003112 RID: 12562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003112")]
		[Address(RVA = "0x8173", Offset = "0x8173", VA = "0x8173")]
		public static IFeedbackFormSource Create(IGame game, [CanBeNull] IAuthDataProvider authDataProvider)
		{
		/* --- GHIDRA: Create ---
		int Gameplay_FeedbackForm_Model_Source_DefaultSource__Create(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57604 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_FeedbackForm_Model_Themes___TypeInfo);
		    DAT_ram_00a57604 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Gameplay_FeedbackForm_Model_Themes___TypeInfo,1);
		  *(undefined1 *)(iVar1 + 0x10) = 3;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x04001AD6 RID: 6870
		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x8")]
		private Themes[] _themes;

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0xC")]
		private uint _requiredFormFields;
	}
}
