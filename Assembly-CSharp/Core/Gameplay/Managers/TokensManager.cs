using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay.Tokens;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117C RID: 4476
	[Token(Token = "0x200117C")]
	public class TokensManager : IAppManager, IBaseManager
	{
		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06006A09 RID: 27145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B3")]
		public string Name
		{
			[Token(Token = "0x6006A09")]
			[Address(RVA = "0xB529", Offset = "0xB529", VA = "0xB529", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002A4 RID: 676
		// (add) Token: 0x06006A0A RID: 27146 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A0B RID: 27147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A4")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A0A")]
			[Address(RVA = "0xB52A", Offset = "0xB52A", VA = "0xB52A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A0B")]
			[Address(RVA = "0xB52B", Offset = "0xB52B", VA = "0xB52B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A5 RID: 677
		// (add) Token: 0x06006A0C RID: 27148 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A0D RID: 27149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A5")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A0C")]
			[Address(RVA = "0xB52C", Offset = "0xB52C", VA = "0xB52C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A0D")]
			[Address(RVA = "0xB52D", Offset = "0xB52D", VA = "0xB52D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06006A0E RID: 27150 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A0F RID: 27151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015B4")]
		public IdTokenRepository IdTokenRepository
		{
			[Token(Token = "0x6006A0E")]
			[Address(RVA = "0xB52E", Offset = "0xB52E", VA = "0xB52E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A0F")]
			[Address(RVA = "0xB52F", Offset = "0xB52F", VA = "0xB52F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A10")]
		[Address(RVA = "0xB530", Offset = "0xB530", VA = "0xB530")]
		public TokensManager(IApp app)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_TokensManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a6385b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Tokens_IdTokenRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TokenatorService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a6385b = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = 0;
		  param2_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_TokenatorService___);
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x82309360;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,10);
		code_r0x82309360:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(iVar4 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x823093e5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,1);
		code_r0x823093e5:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param3 = *(undefined4 *)(iVar4 + 0x28);
		  param1_00 = unnamed_function_1417(Core_Gameplay_Tokens_IdTokenRepository_TypeInfo);
		  Core_Gameplay_GameTutorialV2___ctor(param1_00,param2_00,param3,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  iVar4 = *(int *)(param1 + 8);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A11")]
		[Address(RVA = "0xB531", Offset = "0xB531", VA = "0xB531", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_TokensManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Core_Gameplay_Tokens_IdTokenRepository___ctor(*(undefined4 *)(param1 + 0x10),0);
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A12")]
		[Address(RVA = "0xB532", Offset = "0xB532", VA = "0xB532", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_TokensManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6385c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_16421);
		    DAT_ram_00a6385c = '\x01';
		  }
		  return StringLiteral_16421;
		}
		*/

		}

		// Token: 0x0400382F RID: 14383
		[Token(Token = "0x400382F")]
		[FieldOffset(Offset = "0x14")]
		private readonly IApp _app;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_TokensManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63857 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63857 = '\x01';
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
		void Core_Gameplay_Managers_TokensManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63858 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63858 = '\x01';
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
		void Core_Gameplay_Managers_TokensManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63859 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63859 = '\x01';
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
		void Core_Gameplay_Managers_TokensManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6385a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6385a = '\x01';
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

}
