using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D6 RID: 4822
	[Token(Token = "0x20012D6")]
	public class ManufactureAssistAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173A")]
		protected override string Theme
		{
			[Token(Token = "0x60072A6")]
			[Address(RVA = "0xBCAF", Offset = "0xBCAF", VA = "0xBCAF", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A7")]
		[Address(RVA = "0xBCB0", Offset = "0xBCB0", VA = "0xBCB0", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_ManufactureAssistAnalyticsListener__Init
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ManufactureAssistAnalyticsListener_DismantleStartEvent__
		              );
		    DAT_ram_00a595ec = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x7c);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417
		                    (System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ManufactureAssistAnalyticsListener_DismantleStartEvent__
		             ,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,
		                       System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,
		                       System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo);
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

		// Token: 0x060072A8 RID: 29352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A8")]
		[Address(RVA = "0xBCB1", Offset = "0xBCB1", VA = "0xBCB1", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_ManufactureAssistAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27379);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27416);
		    DAT_ram_00a595ed = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_27379,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27416;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81037ee5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81037ee5:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072A9")]
		[Address(RVA = "0xBCB2", Offset = "0xBCB2", VA = "0xBCB2")]
		private void DismantleStartEvent(ManufactureAssistScope.ManufactureAssistEventArgs e)
		{
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072AA")]
		[Address(RVA = "0xBCB3", Offset = "0xBCB3", VA = "0xBCB3")]
		public ManufactureAssistAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_ManufactureAssistAnalyticsListener___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595ee == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25336);
		    DAT_ram_00a595ee = '\x01';
		  }
		  return StringLiteral_25336;
		}
		*/

		}

		// Token: 0x04003C10 RID: 15376
		[Token(Token = "0x4003C10")]
		private const string START_DISMANTLE = "start_dismantle";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_ManufactureAssistAnalyticsListener__get_Theme
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_ManufactureAssistAnalyticsListener_DismantleStartEvent__
		              );
		    DAT_ram_00a595eb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x7c);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417
		                    (System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_ManufactureAssistAnalyticsListener_DismantleStartEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,
		                       System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,
		                       System_Action_ManufactureAssistScope_ManufactureAssistEventArgs__TypeInfo);
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
