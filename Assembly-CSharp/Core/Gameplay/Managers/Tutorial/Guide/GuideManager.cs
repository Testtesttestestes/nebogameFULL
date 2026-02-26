using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Tutorial.Guide
{
	// Token: 0x02001186 RID: 4486
	[Token(Token = "0x2001186")]
	public class GuideManager : IGameManager, IBaseManager
	{
		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06006A9C RID: 27292 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015D3")]
		public string Name
		{
			[Token(Token = "0x6006A9C")]
			[Address(RVA = "0xB5B5", Offset = "0xB5B5", VA = "0xB5B5", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002B4 RID: 692
		// (add) Token: 0x06006A9D RID: 27293 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A9E RID: 27294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B4")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A9D")]
			[Address(RVA = "0xB5B6", Offset = "0xB5B6", VA = "0xB5B6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A9E")]
			[Address(RVA = "0xB5B7", Offset = "0xB5B7", VA = "0xB5B7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B5 RID: 693
		// (add) Token: 0x06006A9F RID: 27295 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AA0 RID: 27296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B5")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A9F")]
			[Address(RVA = "0xB5B8", Offset = "0xB5B8", VA = "0xB5B8", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AA0")]
			[Address(RVA = "0xB5B9", Offset = "0xB5B9", VA = "0xB5B9", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06006AA1 RID: 27297 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006AA2 RID: 27298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D4")]
		public GuideController Controller
		{
			[Token(Token = "0x6006AA1")]
			[Address(RVA = "0xB5BA", Offset = "0xB5BA", VA = "0xB5BA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AA2")]
			[Address(RVA = "0xB5BB", Offset = "0xB5BB", VA = "0xB5BB")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA3")]
		[Address(RVA = "0xB5BC", Offset = "0xB5BC", VA = "0xB5BC", Slot = "11")]
		public virtual void Init()
		{
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA4")]
		[Address(RVA = "0xB5BD", Offset = "0xB5BD", VA = "0xB5BD")]
		protected void InitComplete()
		{
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA5")]
		[Address(RVA = "0xB5BE", Offset = "0xB5BE", VA = "0xB5BE")]
		protected void DeInitComplete()
		{
		/* --- GHIDRA: DeInitComplete ---
		void Core_Gameplay_Managers_Tutorial_Guide_GuideManager__DeInitComplete
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA6")]
		[Address(RVA = "0xB5BF", Offset = "0xB5BF", VA = "0xB5BF", Slot = "12")]
		public virtual void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_Tutorial_Guide_GuideManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a638ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tutorial_Guide_View_Control_GuideControlWindow_GuideControlWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GuideControlWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12628);
		    DAT_ram_00a638ae = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Tutorial_Guide_View_Control_GuideControlWindow_GuideControlWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12628,param1_00,
		             Method_UI_Windows_PopupController_Show_GuideControlWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA7")]
		[Address(RVA = "0xB5C0", Offset = "0xB5C0", VA = "0xB5C0")]
		public void ShowControlWindow()
		{
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AA8")]
		[Address(RVA = "0xB5C1", Offset = "0xB5C1", VA = "0xB5C1")]
		public GuideManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Tutorial_Guide_GuideManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a638af == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_16522);
		    DAT_ram_00a638af = '\x01';
		  }
		  return StringLiteral_16522;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Tutorial_Guide_GuideManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638a9 = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_Guide_GuideManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638aa = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_Guide_GuideManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638ab = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_Guide_GuideManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638ac = '\x01';
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


		/* --- GHIDRA: set_Controller ---
		void Core_Gameplay_Managers_Tutorial_Guide_GuideManager__set_Controller
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param4;
		  undefined4 param5;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a638ad == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Control_GuideController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_GuideEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_GuideModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22913);
		    DAT_ram_00a638ad = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8230d7d2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8230d7d2:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar7 = *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x14) + 0x14) + 0x298);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8230d888;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8230d888:
		  uVar2 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  if (*(int *)(iVar6 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8230d945;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8230d945:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  param4 = Core_Extensions_Dict_DictExt__GetLongParameter
		                     (*(undefined4 *)(*(int *)(iVar6 + 0x14) + 0x14),StringLiteral_22913,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x148);
		        goto code_r0x8230da05;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x8230da05:
		  param5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  iVar6 = unnamed_function_1417(Gameplay_Tutorial_Guide_Model_GuideModel_TypeInfo);
		  Gameplay_Tutorial_Guide_Model_GuideModel__Dispose(iVar6,uVar2,uVar7,param4,param5,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar4 + 0x10) = 8;
		  *(int *)(iVar6 + 0x10) = iVar4;
		  iVar4 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar4 + 0x10) = 8;
		  *(int *)(iVar6 + 0xc) = iVar4;
		  uVar7 = unnamed_function_1417(Gameplay_Tutorial_Guide_GuideEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_Tutorial_Guide_Control_GuideController_TypeInfo);
		  Gameplay_Tutorial_Guide_Control_GuideController__Dispose(uVar2,iVar6,uVar7,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  MVC_AbstractController__Dispose(uVar2,0);
		  iVar6 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		            (*(undefined4 *)(iVar6 + 0x20),param1,*(undefined4 *)(iVar6 + 0x14));
		  return;
		}
		*/

}
