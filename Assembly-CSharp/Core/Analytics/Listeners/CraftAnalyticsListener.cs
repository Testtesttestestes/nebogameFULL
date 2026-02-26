using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CC RID: 4812
	[Token(Token = "0x20012CC")]
	public class CraftAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172F")]
		protected override string Theme
		{
			[Token(Token = "0x6007269")]
			[Address(RVA = "0xBC72", Offset = "0xBC72", VA = "0xBC72", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726A")]
		[Address(RVA = "0xBC73", Offset = "0xBC73", VA = "0xBC73", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_CraftAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CraftScope_CraftEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CraftAnalyticsListener_StartCraftEvent__);
		    DAT_ram_00a595bc = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x78);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_CraftScope_CraftEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_CraftAnalyticsListener_StartCraftEvent__,0
		            );
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_CraftScope_CraftEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CraftScope_CraftEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_CraftScope_CraftEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_CraftScope_CraftEventArgs__TypeInfo);
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

		// Token: 0x0600726B RID: 29291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726B")]
		[Address(RVA = "0xBC74", Offset = "0xBC74", VA = "0xBC74", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_CraftAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27389);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26573);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26268);
		    DAT_ram_00a595bd = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_26573,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param1_00,StringLiteral_26268,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_27389;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8103458b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103458b:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600726C RID: 29292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726C")]
		[Address(RVA = "0xBC75", Offset = "0xBC75", VA = "0xBC75")]
		private void StartCraftEvent(CraftScope.CraftEventArgs e)
		{
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726D")]
		[Address(RVA = "0xBC76", Offset = "0xBC76", VA = "0xBC76")]
		public CraftAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_CraftAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595be == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22488);
		    DAT_ram_00a595be = '\x01';
		  }
		  return StringLiteral_22488;
		}
		*/

		}

		// Token: 0x04003BFC RID: 15356
		[Token(Token = "0x4003BFC")]
		private const string START = "start";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_CraftAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CraftScope_CraftEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_CraftAnalyticsListener_StartCraftEvent__);
		    DAT_ram_00a595bb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x78);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_CraftScope_CraftEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_CraftAnalyticsListener_StartCraftEvent__,0
		            );
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_CraftScope_CraftEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CraftScope_CraftEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_CraftScope_CraftEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_CraftScope_CraftEventArgs__TypeInfo);
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
