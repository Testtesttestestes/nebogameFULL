using System;
using System.Collections.Generic;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.View.Fx
{
	// Token: 0x0200035A RID: 858
	[Token(Token = "0x200035A")]
	public class SnowFxAnimationController : SnowFxControllerBase
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139F")]
		[Address(RVA = "0x658F", Offset = "0x658F", VA = "0x658F", Slot = "4")]
		protected override void ValidateEnable(bool enable)
		{
		/* --- GHIDRA: ValidateEnable ---
		void Gameplay_World_View_Fx_SnowFxAnimationController__ValidateEnable
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_World_View_Fx_SnowFxAnimationController__OnDisable(param1,1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x6590", Offset = "0x6590", VA = "0x6590")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_World_View_Fx_SnowFxAnimationController__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_World_View_Fx_SnowFxAnimationController__OnDisable(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x6591", Offset = "0x6591", VA = "0x6591")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_World_View_Fx_SnowFxAnimationController__OnDisable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58c6b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameSpineUiAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GameSpineUiAnimation__ForEach__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_View_Fx_SnowFxAnimationController___c__DisplayClass4_0__SwitchAnimations_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_World_View_Fx_SnowFxAnimationController___c__DisplayClass4_0_TypeInfo);
		    DAT_ram_00a58c6b = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_World_View_Fx_SnowFxAnimationController___c__DisplayClass4_0_TypeInfo
		                        );
		  *(undefined1 *)(param2_00 + 8) = (undefined1)param2;
		  param1_01 = *(undefined4 *)(param1 + 0x3c);
		  param1_00 = unnamed_function_1417(System_Action_GameSpineUiAnimation__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Gameplay_World_View_Fx_SnowFxAnimationController___c__DisplayClass4_0__SwitchAnimations_b__0__
		             ,0);
		  System_Collections_Generic_List_UsageHint___FindLastIndex
		            (param1_01,param1_00,
		             Method_System_Collections_Generic_List_GameSpineUiAnimation__ForEach__);
		  return;
		}
		*/

		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A2")]
		[Address(RVA = "0x6592", Offset = "0x6592", VA = "0x6592")]
		private void SwitchAnimations(bool enable)
		{
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x6593", Offset = "0x6593", VA = "0x6593")]
		public SnowFxAnimationController()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_View_Fx_SnowFxAnimationController___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58c6c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_View_Fx_SnowFxAnimationController___c_TypeInfo);
		    DAT_ram_00a58c6c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_World_View_Fx_SnowFxAnimationController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_World_View_Fx_SnowFxAnimationController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private List<GameSpineUiAnimation> _animations;
	}
}
