using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Il2CppDummyDll;

namespace Gameplay.Tutorial.Guide.Control
{
	// Token: 0x02000490 RID: 1168
	[Token(Token = "0x2000490")]
	public class TutorialGuideObserver : IDisposable
	{
		// Token: 0x06001BAD RID: 7085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x6D2C", Offset = "0x6D2C", VA = "0x6D2C", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__StartTutorial(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x6D2D", Offset = "0x6D2D", VA = "0x6D2D")]
		public void StartTutorial(GuideConfig config)
		{
		/* --- GHIDRA: StartTutorial ---
		void Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__StartTutorial
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param4;
		  undefined4 param5;
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar2;
		  undefined8 *param2_01;
		  undefined4 param3_00;
		  undefined1 auStack_30 [8];
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a584b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ValueTuple_string__uint____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ValueTuple_string__uint___get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ValueTuple_string__uint___get_Value__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_string__uint___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16517);
		    DAT_ram_00a584b2 = '\x01';
		  }
		  iVar1 = func_ii_4769(*(undefined4 *)(*(int *)(param2 + 0x10) + 0x2c),0);
		  if (iVar1 == 0) {
		    iVar2 = *(int *)(param2 + 0x10);
		    iVar1 = *(int *)(iVar2 + 0x30);
		    if (iVar1 != 0) {
		      param2_01 = (undefined8 *)(param1 + 8);
		      if (*(char *)(param1 + 8) != '\0') {
		        System_Nullable_InputAction_CallbackContext___get_HasValue
		                  (&local_20,param2_01,Method_System_Nullable_ValueTuple_string__uint___get_Value__)
		        ;
		        iVar1 = System_Collections_CollectionBase___ctor
		                          ((undefined4)local_20,*(undefined4 *)(*(int *)(param2 + 0x10) + 0x2c),0);
		        if ((iVar1 != 0) &&
		           (System_Nullable_InputAction_CallbackContext___get_HasValue
		                      (&local_20,param2_01,
		                       Method_System_Nullable_ValueTuple_string__uint___get_Value__),
		           local_20._4_4_ == *(int *)(*(int *)(param2 + 0x10) + 0x30))) {
		          return;
		        }
		        Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__FinishTutorial(param1,auStack_30);
		        iVar2 = *(int *)(param2 + 0x10);
		        iVar1 = *(int *)(iVar2 + 0x30);
		      }
		      local_10 = 0;
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,*(undefined4 *)(iVar2 + 0x2c),iVar1,
		                 Method_System_ValueTuple_string__uint___ctor__);
		      local_18 = 0;
		      local_20 = 0;
		      local_28 = local_10;
		      local_8 = local_10;
		      System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_Value
		                (&local_20,&local_28,Method_System_Nullable_ValueTuple_string__uint____ctor__);
		      *(undefined4 *)(param1 + 0x10) = local_18;
		      *param2_01 = local_20;
		      iVar1 = System_Uri___ctor(0);
		      iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x10) + 8);
		      if (iVar1 == 0) {
		        return;
		      }
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      System_Nullable_InputAction_CallbackContext___get_HasValue
		                (&local_20,param2_01,Method_System_Nullable_ValueTuple_string__uint___get_Value__);
		      param4 = (undefined4)local_20;
		      System_Nullable_InputAction_CallbackContext___get_HasValue
		                (&local_20,param2_01,Method_System_Nullable_ValueTuple_string__uint___get_Value__);
		      param5 = local_20._4_4_;
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,param4,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(StringLiteral_16517,0);
		  if (*(char *)(param1 + 8) != '\0') {
		    Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__FinishTutorial(param1,auStack_30);
		    *(undefined4 *)(param1 + 0x10) = 0;
		    *(undefined8 *)(param1 + 8) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x6D2E", Offset = "0x6D2E", VA = "0x6D2E")]
		public void StartStep(GuideConfig config)
		{
		/* --- GHIDRA: StartStep ---
		void Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__StartStep
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__FinishTutorial(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x6D2F", Offset = "0x6D2F", VA = "0x6D2F")]
		public void FinishTutorial()
		{
		/* --- GHIDRA: FinishTutorial ---
		void Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__FinishTutorial
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined8 *param2_01;
		  undefined4 param3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a584b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ValueTuple_string__uint___get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ValueTuple_string__uint___get_Value__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs_TypeInfo)
		    ;
		    DAT_ram_00a584b3 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    param2_01 = (undefined8 *)(param1 + 8);
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x10) + 0xc);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      System_Nullable_InputAction_CallbackContext___get_HasValue
		                (&local_8,param2_01,Method_System_Nullable_ValueTuple_string__uint___get_Value__);
		      System_Nullable_InputAction_CallbackContext___get_HasValue
		                (&local_8,param2_01,Method_System_Nullable_ValueTuple_string__uint___get_Value__);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3,local_8,local_4,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		    *param2_01 = 0;
		    *(undefined4 *)(param1 + 0x10) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x6D30", Offset = "0x6D30", VA = "0x6D30")]
		public void FinishStep()
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x6D31", Offset = "0x6D31", VA = "0x6D31")]
		public TutorialGuideObserver()
		{
		}

		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x8")]
		[TupleElementNames(new string[]
		{
			"stageId",
			"step"
		})]
		private ValueTuple<string, uint>? _currentStepMeta;
	}
}
