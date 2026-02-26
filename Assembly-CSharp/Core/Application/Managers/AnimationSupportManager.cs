using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x0200124A RID: 4682
	[Token(Token = "0x200124A")]
	public class AnimationSupportManager : IAppManager, IBaseManager
	{
		// Token: 0x140002E2 RID: 738
		// (add) Token: 0x06006EED RID: 28397 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006EEE RID: 28398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E2")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006EED")]
			[Address(RVA = "0xB96B", Offset = "0xB96B", VA = "0xB96B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006EEE")]
			[Address(RVA = "0xB96C", Offset = "0xB96C", VA = "0xB96C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002E3 RID: 739
		// (add) Token: 0x06006EEF RID: 28399 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006EF0 RID: 28400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E3")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006EEF")]
			[Address(RVA = "0xB96D", Offset = "0xB96D", VA = "0xB96D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006EF0")]
			[Address(RVA = "0xB96E", Offset = "0xB96E", VA = "0xB96E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EF1")]
		[Address(RVA = "0xB96F", Offset = "0xB96F", VA = "0xB96F", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EF2")]
		[Address(RVA = "0xB970", Offset = "0xB970", VA = "0xB970", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Application_Managers_AnimationSupportManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a80e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3129);
		    DAT_ram_00a5a80e = '\x01';
		  }
		  return StringLiteral_3129;
		}
		*/

		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06006EF3 RID: 28403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016AA")]
		public string Name
		{
			[Token(Token = "0x6006EF3")]
			[Address(RVA = "0xB971", Offset = "0xB971", VA = "0xB971", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EF4")]
		[Address(RVA = "0xB972", Offset = "0xB972", VA = "0xB972")]
		public AnimationSupportManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Application_Managers_AnimationSupportManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a80f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3169);
		    DAT_ram_00a5a80f = '\x01';
		  }
		  return StringLiteral_3169;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_AnimationSupportManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a80a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a80a = '\x01';
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
		void Core_Application_Managers_AnimationSupportManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a80b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a80b = '\x01';
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
		void Core_Application_Managers_AnimationSupportManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a80c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a80c = '\x01';
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
		void Core_Application_Managers_AnimationSupportManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a80d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_AnimationSupportData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Animations_GameSpineAnimationBindings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3128);
		    DAT_ram_00a5a80d = '\x01';
		  }
		  param1_00 = (int *)UnityEngine_Resources__FindObjectsOfTypeAll(StringLiteral_3128,0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Core_Application_Managers_AnimationSupportData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Core_Application_Managers_AnimationSupportData_TypeInfo + 0xb8) * 4
		                + -4) != Core_Application_Managers_AnimationSupportData_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Core_Application_Managers_AnimationSupportData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  **(int **)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c) = param1_00[3];
		  iVar1 = *(int *)(Core_Animations_GameSpineAnimationBindings_TypeInfo + 0x5c);
		  *(int *)(iVar1 + 4) = param1_00[4];
		  *(int *)(iVar1 + 8) = param1_00[5];
		  *(int *)(iVar1 + 0xc) = param1_00[6];
		  *(int *)(iVar1 + 0x10) = param1_00[7];
		  *(int *)(iVar1 + 0x18) = param1_00[10];
		  *(int *)(iVar1 + 0x14) = param1_00[0xb];
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
