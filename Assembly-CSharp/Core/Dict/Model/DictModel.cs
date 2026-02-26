using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Files;
using Core.Gameplay;
using Core.Gameplay.Managers.Configuration;
using Core.Log.Files;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Core.Dict.Model
{
	// Token: 0x02001096 RID: 4246
	[Token(Token = "0x2001096")]
	public class DictModel : AbstractModel
	{
		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x060062C3 RID: 25283 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062C4 RID: 25284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AB")]
		public IAuthDataProvider AuthDataProvider
		{
			[Token(Token = "0x60062C3")]
			[Address(RVA = "0xAEE3", Offset = "0xAEE3", VA = "0xAEE3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062C4")]
			[Address(RVA = "0xAEE4", Offset = "0xAEE4", VA = "0xAEE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x060062C5 RID: 25285 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062C6 RID: 25286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AC")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x60062C5")]
			[Address(RVA = "0xAEE5", Offset = "0xAEE5", VA = "0xAEE5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062C6")]
			[Address(RVA = "0xAEE6", Offset = "0xAEE6", VA = "0xAEE6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x060062C7 RID: 25287 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062C8 RID: 25288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AD")]
		public Dictionaries RawData
		{
			[Token(Token = "0x60062C7")]
			[Address(RVA = "0xAEE7", Offset = "0xAEE7", VA = "0xAEE7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062C8")]
			[Address(RVA = "0xAEE8", Offset = "0xAEE8", VA = "0xAEE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x060062C9 RID: 25289 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062CA RID: 25290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AE")]
		public Dictionary<string, AssetDic> AssetsHash
		{
			[Token(Token = "0x60062C9")]
			[Address(RVA = "0xAEE9", Offset = "0xAEE9", VA = "0xAEE9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062CA")]
			[Address(RVA = "0xAEEA", Offset = "0xAEEA", VA = "0xAEEA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062CB")]
		[Address(RVA = "0xAEEB", Offset = "0xAEEB", VA = "0xAEEB", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Dict_Model_DictModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param6,0);
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060062CC RID: 25292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062CC")]
		[Address(RVA = "0xAEEC", Offset = "0xAEEC", VA = "0xAEEC")]
		public DictModel(IFileManager fileManager, IAuthDataProvider authDataProvider, IPlatformConfigurationProvider configurationProvider, FileDownloadLogger fileDownloadLogger, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dict_Model_DictModel___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060062CD RID: 25293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062CD")]
		[Address(RVA = "0xAEED", Offset = "0xAEED", VA = "0xAEED")]
		public void SetData(Dictionaries rawData, Dictionary<string, AssetDic> assetsHash)
		{
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x060062CE RID: 25294 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013AF")]
		public string DownloadPath
		{
			[Token(Token = "0x60062CE")]
			[Address(RVA = "0x36DB", Offset = "0x36DB", VA = "0x36DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x060062CF RID: 25295 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062D0 RID: 25296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B0")]
		public string CurrentDownloadPath
		{
			[Token(Token = "0x60062CF")]
			[Address(RVA = "0xAEEE", Offset = "0xAEEE", VA = "0xAEEE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062D0")]
			[Address(RVA = "0xAEEF", Offset = "0xAEEF", VA = "0xAEEF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x04003508 RID: 13576
		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0x1C")]
		public FileDownloadLogger FileDownloadLogger;

		// Token: 0x04003509 RID: 13577
		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0x20")]
		public readonly IFileManager FileManager;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_AssetsHash ---
		void Core_Dict_Model_DictModel__set_AssetsHash(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0xc) = 0;
		  *(undefined8 *)(param1 + 0x14) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_DownloadPath ---
		void Core_Dict_Model_DictModel__get_DownloadPath(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  int *param1_01;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a60755 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IFileContent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Dict_Controller_BaseDictController_ParseResultDic__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Files_IFileManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6532);
		    Mono_Security_ASN1__get_Item(&StringLiteral_243);
		    DAT_ram_00a60755 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar2 + 0x24);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar5 != 0) {
		    uVar4 = System_Int32__ToString
		                      (StringLiteral_6532,param2,StringLiteral_243,*(undefined4 *)(iVar2 + 0x24),0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar4,0);
		    return;
		  }
		  *(undefined4 *)(iVar2 + 0x24) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0x20);
		  uVar1 = 0;
		  iVar2 = System_Uri___ctor(0);
		  param1_01 = *(int **)(*(int *)(iVar2 + 0x48) + 0x10);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cd9f1d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,0);
		code_r0x81cd9f1d:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  uVar6 = *(undefined4 *)(iVar2 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar7 = *(undefined4 *)(iVar2 + 0x24);
		  uVar1 = 0;
		  uVar4 = unnamed_function_1417(System_Action_IFileContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,Method_Core_Dict_Controller_BaseDictController_ParseResultDic__,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 0x1c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Files_IFileManager_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x81cd9fff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Files_IFileManager_TypeInfo,1);
		code_r0x81cd9fff:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar6,uVar7,1,uVar4,uVar8,puVar3[1]);
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentDownloadPath ---
		undefined4
		Core_Dict_Model_DictModel__set_CurrentDownloadPath(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60743 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Id__);
		    DAT_ram_00a60743 = '\x01';
		  }
		  uVar1 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (param2,*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

}
