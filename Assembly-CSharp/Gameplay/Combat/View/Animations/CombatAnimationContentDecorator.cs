using System;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000980 RID: 2432
	[Token(Token = "0x2000980")]
	public class CombatAnimationContentDecorator : CombatAnimation.IContent, IDisposable
	{
		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060039F1 RID: 14833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5F")]
		public AssetDic SoundAsset
		{
			[Token(Token = "0x60039F0")]
			[Address(RVA = "0x8974", Offset = "0x8974", VA = "0x8974")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60039F1")]
			[Address(RVA = "0x8975", Offset = "0x8975", VA = "0x8975")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F2")]
		[Address(RVA = "0x8976", Offset = "0x8976", VA = "0x8976")]
		public CombatAnimationContentDecorator(IGameAudio audio, CombatAnimation.IContent content, string text, CombatEventsToast toast)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57e05 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a57e05 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e68333;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x80e68333:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F3")]
		[Address(RVA = "0x8977", Offset = "0x8977", VA = "0x8977", Slot = "12")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__Dispose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57e06 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e06 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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

		// Token: 0x14000187 RID: 391
		// (add) Token: 0x060039F4 RID: 14836 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060039F5 RID: 14837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000187")]
		private event Action<CombatAnimation.IContent> _onCompleteEvent
		{
			[Token(Token = "0x60039F4")]
			[Address(RVA = "0x8978", Offset = "0x8978", VA = "0x8978")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60039F5")]
			[Address(RVA = "0x8979", Offset = "0x8979", VA = "0x8979")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000188 RID: 392
		// (add) Token: 0x060039F6 RID: 14838 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060039F7 RID: 14839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000188")]
		public event Action<CombatAnimation.IContent> OnCompleteEvent
		{
			[Token(Token = "0x60039F6")]
			[Address(RVA = "0x897A", Offset = "0x897A", VA = "0x897A", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x60039F7")]
			[Address(RVA = "0x897B", Offset = "0x897B", VA = "0x897B", Slot = "5")]
			remove
			{
			}
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F8")]
		[Address(RVA = "0x897C", Offset = "0x897C", VA = "0x897C")]
		private void HandleOnCompleteEvent(CombatAnimation.IContent content)
		{
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x897D", Offset = "0x897D", VA = "0x897D")]
		public void SetContent(CombatAnimation.IContent content)
		{
		/* --- GHIDRA: SetContent ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__SetContent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57e0a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    DAT_ram_00a57e0a = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 0x10) + 0x10);
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar3,*(undefined4 *)(param1 + 0x14),*(undefined4 *)(iVar4 + 0x2d4));
		  piVar3 = *(int **)(param1 + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e687cc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,2)
		  ;
		code_r0x80e687cc:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Gameplay_Combat_View_GameField_GuideTurnHint__GetTexture(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FA")]
		[Address(RVA = "0x897E", Offset = "0x897E", VA = "0x897E", Slot = "6")]
		public void Show()
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__Show
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57e0b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    DAT_ram_00a57e0b = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x80e6887e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,3)
		  ;
		code_r0x80e6887e:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Core_Dev_DevMenuVideoAd___ctor(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x060039FB RID: 14843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FB")]
		[Address(RVA = "0x897F", Offset = "0x897F", VA = "0x897F", Slot = "7")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__Hide
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a57e0c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    DAT_ram_00a57e0c = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 8);
		  if (iVar3 != 0) {
		    uVar1 = 0;
		    piVar5 = *(int **)(param1 + 0x18);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Sound_Control_IGameAudio_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x80e68941;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Sound_Control_IGameAudio_TypeInfo,2);
		code_r0x80e68941:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar5,iVar3,puVar2[1]);
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(param1 + 0xc);
		  iVar3 = *piVar5;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80e689c7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,4)
		  ;
		code_r0x80e689c7:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,param2,puVar2[1]);
		  Gameplay_Combat_View_CombatEventsToast__set_Duration(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FC")]
		[Address(RVA = "0x8980", Offset = "0x8980", VA = "0x8980", Slot = "8")]
		public void Play(bool loop)
		{
		/* --- GHIDRA: Play ---
		undefined4
		Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__Play(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57e0d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    DAT_ram_00a57e0d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x80e68a7b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,5)
		  ;
		code_r0x80e68a7b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B60")]
		public Transform Transform
		{
			[Token(Token = "0x60039FD")]
			[Address(RVA = "0x8981", Offset = "0x8981", VA = "0x8981", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060039FE RID: 14846 RVA: 0x0000B910 File Offset: 0x00009B10
		// (set) Token: 0x060039FF RID: 14847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B61")]
		public bool IsLeft
		{
			[Token(Token = "0x60039FE")]
			[Address(RVA = "0x8982", Offset = "0x8982", VA = "0x8982", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039FF")]
			[Address(RVA = "0x8983", Offset = "0x8983", VA = "0x8983", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x0400200B RID: 8203
		[Token(Token = "0x400200B")]
		[FieldOffset(Offset = "0xC")]
		private CombatAnimation.IContent _content;

		// Token: 0x0400200C RID: 8204
		[Token(Token = "0x400200C")]
		[FieldOffset(Offset = "0x10")]
		private CombatEventsToast _toast;

		// Token: 0x0400200D RID: 8205
		[Token(Token = "0x400200D")]
		[FieldOffset(Offset = "0x14")]
		private string _text;

		// Token: 0x0400200E RID: 8206
		[Token(Token = "0x400200E")]
		[FieldOffset(Offset = "0x18")]
		private IGameAudio _audio;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SoundAsset ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__set_SoundAsset
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  return;
		}
		*/


		/* --- GHIDRA: add__onCompleteEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__add__onCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57e07 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e07 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: remove__onCompleteEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__remove__onCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int param1_00;
		  int *param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a57e08 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Animations_CombatAnimationContentDecorator_HandleOnCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    DAT_ram_00a57e08 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0xc);
		  uVar4 = unnamed_function_1417(System_Action_CombatAnimation_IContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Combat_View_Animations_CombatAnimationContentDecorator_HandleOnCompleteEvent__
		             ,0);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e68520;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,0)
		  ;
		code_r0x80e68520:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,puVar5[1]);
		  if (DAT_ram_00a57e06 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e06 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar3 = 0;
		    param1_00 = UnityEngine_UI_Image__set_sprite(iVar6,param2,0);
		    uVar4 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar3 = func_ii_1082(param1_00,System_Action_CombatAnimation_IContent__TypeInfo), iVar3 == 0
		       )) break;
		    iVar3 = func_ii_4329(param1 + 0x1c,iVar3,iVar6);
		    bVar1 = iVar3 == iVar6;
		    iVar6 = iVar3;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnCompleteEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__add_OnCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int param1_00;
		  int *param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a57e09 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Animations_CombatAnimationContentDecorator_HandleOnCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    DAT_ram_00a57e09 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0xc);
		  uVar4 = unnamed_function_1417(System_Action_CombatAnimation_IContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Combat_View_Animations_CombatAnimationContentDecorator_HandleOnCompleteEvent__
		             ,0);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80e68670;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,1)
		  ;
		code_r0x80e68670:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,puVar5[1]);
		  if (DAT_ram_00a57e07 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e07 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar3 = 0;
		    param1_00 = func_ii_7048(iVar6,param2,0);
		    uVar4 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar3 = func_ii_1082(param1_00,System_Action_CombatAnimation_IContent__TypeInfo), iVar3 == 0
		       )) break;
		    iVar3 = func_ii_4329(param1 + 0x1c,iVar3,iVar6);
		    bVar1 = iVar3 == iVar6;
		    iVar6 = iVar3;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnCompleteEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__remove_OnCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: get_Transform ---
		undefined4
		Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__get_Transform
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57e0e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    DAT_ram_00a57e0e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x80e68b22;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,6)
		  ;
		code_r0x80e68b22:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_IsLeft ---
		void Gameplay_Combat_View_Animations_CombatAnimationContentDecorator__get_IsLeft
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57e0f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    DAT_ram_00a57e0f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf8);
		        goto code_r0x80e68bc9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,7)
		  ;
		code_r0x80e68bc9:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

}
