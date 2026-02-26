using System;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Audio
{
	// Token: 0x020011F6 RID: 4598
	[Token(Token = "0x20011F6")]
	public class AudioManager : IGameManager, IBaseManager
	{
		// Token: 0x140002D1 RID: 721
		// (add) Token: 0x06006D32 RID: 27954 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D33 RID: 27955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D1")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006D32")]
			[Address(RVA = "0xB81A", Offset = "0xB81A", VA = "0xB81A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D33")]
			[Address(RVA = "0xB81B", Offset = "0xB81B", VA = "0xB81B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002D2 RID: 722
		// (add) Token: 0x06006D34 RID: 27956 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D35 RID: 27957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D2")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006D34")]
			[Address(RVA = "0xB81C", Offset = "0xB81C", VA = "0xB81C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D35")]
			[Address(RVA = "0xB81D", Offset = "0xB81D", VA = "0xB81D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D37 RID: 27959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001636")]
		public IGame Game
		{
			[Token(Token = "0x6006D36")]
			[Address(RVA = "0xB81E", Offset = "0xB81E", VA = "0xB81E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D37")]
			[Address(RVA = "0xB81F", Offset = "0xB81F", VA = "0xB81F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D38")]
		[Address(RVA = "0xB820", Offset = "0xB820", VA = "0xB820")]
		public AudioManager(IGame game)
		{
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D3A RID: 27962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001637")]
		public AudioController Controller
		{
			[Token(Token = "0x6006D39")]
			[Address(RVA = "0xB821", Offset = "0xB821", VA = "0xB821")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D3A")]
			[Address(RVA = "0xB822", Offset = "0xB822", VA = "0xB822")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3B")]
		[Address(RVA = "0xB823", Offset = "0xB823", VA = "0xB823", Slot = "11")]
		public virtual void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Audio_AudioManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a75a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Audio_AudioManager_HandleInitEvent__);
		    DAT_ram_00a5a75a = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_Audio_AudioManager_HandleInitEvent__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3C")]
		[Address(RVA = "0xB824", Offset = "0xB824", VA = "0xB824")]
		protected void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Core_Gameplay_Managers_Audio_AudioManager__HandleInitEvent(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x18),0);
		  iVar2 = **(int **)(param1 + 0x18);
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar2 + 0x104));
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  iVar2 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x134));
		  *(undefined8 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 0x18) = 0;
		  iVar2 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D3D")]
		[Address(RVA = "0xB825", Offset = "0xB825", VA = "0xB825", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_Audio_AudioManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a75b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3435);
		    DAT_ram_00a5a75b = '\x01';
		  }
		  return StringLiteral_3435;
		}
		*/

		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06006D3E RID: 27966 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001638")]
		public string Name
		{
			[Token(Token = "0x6006D3E")]
			[Address(RVA = "0xB826", Offset = "0xB826", VA = "0xB826", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400392B RID: 14635
		[Token(Token = "0x400392B")]
		[FieldOffset(Offset = "0x14")]
		protected AudioSourceMediator _meditor;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Audio_AudioManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a756 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a756 = '\x01';
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
		void Core_Gameplay_Managers_Audio_AudioManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a757 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a757 = '\x01';
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
		void Core_Gameplay_Managers_Audio_AudioManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a758 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a758 = '\x01';
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
		void Core_Gameplay_Managers_Audio_AudioManager__set_Controller(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a5a759 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_AudioController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_AudioEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Audio_AudioManager_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Model_AudioModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_AudioSourceMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a759 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Sound_AudioEvents_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x8126701a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x8126701a:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x158);
		        goto code_r0x8126709f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8126709f:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x20);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x81267127;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81267127:
		  uVar1 = 0;
		  param4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x812671ac;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812671ac:
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  param1_00 = unnamed_function_1417(Gameplay_Sound_Model_AudioModel_TypeInfo);
		  Gameplay_Sound_Model_AudioModel__Dispose(param1_00,uVar4,uVar8,param4,uVar5,0);
		  uVar8 = *(undefined4 *)(iVar2 + 8);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,Method_Core_Gameplay_Managers_Audio_AudioManager_HandleInitEvent__,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) || (*(int **)(iVar2 + 8) = piVar6, *piVar6 != iVar7))
		  {
		    System_Activator__CreateInstance(piVar6,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = unnamed_function_1417(Gameplay_Sound_Control_AudioController_TypeInfo);
		  Gameplay_Sound_Control_AudioController__set__detectCoroutine(uVar4,param1_00,iVar2,0);
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  piVar6 = (int *)unnamed_function_1417(Gameplay_Sound_Control_AudioSourceMediator_TypeInfo);
		  Gameplay_Sound_Control_AudioSourceMediator___c__DisplayClass6_0___HandleStopMusicEvent_b__0
		            (piVar6,param1_00,iVar2,uVar4,0);
		  *(int **)(param1 + 0x14) = piVar6;
		  iVar2 = System_Uri___ctor(0);
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,*(undefined4 *)(*(int *)(iVar2 + 0x18) + 0x30),*(undefined4 *)(*piVar6 + 0x164))
		  ;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		undefined4 Core_Gameplay_Managers_Audio_AudioManager__get_Name(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a75c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_16521);
		    DAT_ram_00a5a75c = '\x01';
		  }
		  return StringLiteral_16521;
		}
		*/

}
