using System;
using Core.Data.User;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DD RID: 4829
	[Token(Token = "0x20012DD")]
	public class SettingsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x060072E3 RID: 29411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001741")]
		protected override string Theme
		{
			[Token(Token = "0x60072E3")]
			[Address(RVA = "0xBCEC", Offset = "0xBCEC", VA = "0xBCEC", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E4")]
		[Address(RVA = "0xBCED", Offset = "0xBCED", VA = "0xBCED", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_SettingsAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59622 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SettingsAnalyticsListener_SettingsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SettingsAnalyticsListener_SettingsInitializedEvent__
		              );
		    DAT_ram_00a59622 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x24);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SettingsAnalyticsListener_SettingsInitializedEvent__,0)
		  ;
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x24);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SettingsAnalyticsListener_SettingsChangedEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E5")]
		[Address(RVA = "0xBCEE", Offset = "0xBCEE", VA = "0xBCEE", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_SettingsAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a59623 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21094);
		    DAT_ram_00a59623 = '\x01';
		  }
		  Core_Analytics_Listeners_SettingsAnalyticsListener__SettingsChangedEvent
		            (param1,*(undefined4 *)(param2 + 0x10),param1);
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  uVar1 = StringLiteral_21094;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8103df85;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103df85:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar3,uVar1,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E6")]
		[Address(RVA = "0xBCEF", Offset = "0xBCEF", VA = "0xBCEF")]
		private void SettingsChangedEvent(SettingsScope.SettingsEventArgs e)
		{
		/* --- GHIDRA: SettingsChangedEvent ---
		void Core_Analytics_Listeners_SettingsAnalyticsListener__SettingsChangedEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  undefined1 local_6;
		  undefined1 local_5;
		  undefined1 local_4;
		  undefined1 local_3;
		  undefined1 local_2;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a59624 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27132);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27129);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27130);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27128);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27127);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27131);
		    DAT_ram_00a59624 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 8);
		  local_1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar1 = StringLiteral_27128;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8103e09c;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8103e09c:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  piVar5 = *(int **)(param1 + 8);
		  local_2 = *(undefined1 *)((int)param2 + 9);
		  uVar2 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_2);
		  uVar1 = StringLiteral_27129;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8103e145;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8103e145:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  piVar5 = *(int **)(param1 + 8);
		  local_3 = (undefined1)param2[2];
		  uVar2 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_3);
		  uVar1 = StringLiteral_27130;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8103e1ee;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8103e1ee:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  piVar5 = *(int **)(param1 + 8);
		  local_4 = *(undefined1 *)((int)param2 + 10);
		  uVar2 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_4);
		  uVar1 = StringLiteral_27127;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8103e297;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8103e297:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  piVar5 = *(int **)(param1 + 8);
		  local_5 = *(undefined1 *)((int)param2 + 0xb);
		  uVar2 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_5);
		  uVar1 = StringLiteral_27131;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8103e340;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8103e340:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  piVar5 = *(int **)(param1 + 8);
		  local_6 = (undefined1)param2[3];
		  uVar2 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_6);
		  uVar1 = StringLiteral_27132;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x8103e3e9;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,1);
		code_r0x8103e3e9:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar5,uVar1,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E7")]
		[Address(RVA = "0xBCF0", Offset = "0xBCF0", VA = "0xBCF0")]
		private void SetSettings(UserSettings userSettings)
		{
		/* --- GHIDRA: SetSettings ---
		void Core_Analytics_Listeners_SettingsAnalyticsListener__SetSettings
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Analytics_Listeners_SettingsAnalyticsListener__SettingsChangedEvent
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E8")]
		[Address(RVA = "0xBCF1", Offset = "0xBCF1", VA = "0xBCF1")]
		private void SettingsInitializedEvent(SettingsScope.SettingsEventArgs e)
		{
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072E9")]
		[Address(RVA = "0xBCF2", Offset = "0xBCF2", VA = "0xBCF2")]
		public SettingsAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_SettingsAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59625 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27165);
		    DAT_ram_00a59625 = '\x01';
		  }
		  return StringLiteral_27165;
		}
		*/

		}

		// Token: 0x04003C2B RID: 15403
		[Token(Token = "0x4003C2B")]
		private const string SETTINGS_CHANGED = "changed";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_SettingsAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a59621 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SettingsAnalyticsListener_SettingsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SettingsAnalyticsListener_SettingsInitializedEvent__
		              );
		    DAT_ram_00a59621 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x24);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SettingsAnalyticsListener_SettingsInitializedEvent__,0)
		  ;
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x24);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SettingsAnalyticsListener_SettingsChangedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_SettingsScope_SettingsEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SettingsScope_SettingsEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
