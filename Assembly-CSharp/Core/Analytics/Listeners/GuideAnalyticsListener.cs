using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D3 RID: 4819
	[Token(Token = "0x20012D3")]
	public class GuideAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06007291 RID: 29329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001737")]
		protected override string Theme
		{
			[Token(Token = "0x6007291")]
			[Address(RVA = "0xBC9A", Offset = "0xBC9A", VA = "0xBC9A", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007292")]
		[Address(RVA = "0xBC9B", Offset = "0xBC9B", VA = "0xBC9B", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_GuideAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GuideScope_GuideEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_GuideAnalyticsListener_GuideStepCompleteEvent__);
		    DAT_ram_00a595d9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x28);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GuideScope_GuideEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GuideAnalyticsListener_GuideStepCompleteEvent__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_GuideScope_GuideEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GuideScope_GuideEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_GuideScope_GuideEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_GuideScope_GuideEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007293 RID: 29331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007293")]
		[Address(RVA = "0xBC9C", Offset = "0xBC9C", VA = "0xBC9C", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_GuideAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  undefined1 local_9;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27442);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27883);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27444);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27446);
		    DAT_ram_00a595da = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x10) + 8);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_27883,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param1_00,StringLiteral_27444,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  iVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param2 + 0x10),0);
		  local_9 = *(int *)(*(int *)(iVar3 + 0x24) + 0xc) == 1;
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_9);
		  func_ii_2946(param1_00,StringLiteral_27446,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27442;
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x81036466;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81036466:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar2,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007294 RID: 29332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007294")]
		[Address(RVA = "0xBC9D", Offset = "0xBC9D", VA = "0xBC9D")]
		private void GuideStepCompleteEvent(GuideScope.GuideEventArgs e)
		{
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007295")]
		[Address(RVA = "0xBC9E", Offset = "0xBC9E", VA = "0xBC9E")]
		public GuideAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_GuideAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595db == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_24690);
		    DAT_ram_00a595db = '\x01';
		  }
		  return StringLiteral_24690;
		}
		*/

		}

		// Token: 0x04003C07 RID: 15367
		[Token(Token = "0x4003C07")]
		private const string STEP_COMPLETE = "step_complete";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_GuideAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GuideScope_GuideEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_GuideAnalyticsListener_GuideStepCompleteEvent__);
		    DAT_ram_00a595d8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x28);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GuideScope_GuideEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_GuideAnalyticsListener_GuideStepCompleteEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_GuideScope_GuideEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GuideScope_GuideEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_GuideScope_GuideEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_GuideScope_GuideEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
