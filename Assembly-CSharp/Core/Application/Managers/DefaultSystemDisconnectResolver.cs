using System;
using System.Runtime.CompilerServices;
using Core.Application.Managers.Connection;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.System;

namespace Core.Application.Managers
{
	// Token: 0x0200124E RID: 4686
	[Token(Token = "0x200124E")]
	public class DefaultSystemDisconnectResolver : ISystemDisconnectResolver
	{
		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x00014418 File Offset: 0x00012618
		// (set) Token: 0x06006F10 RID: 28432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016AF")]
		public DisconnectCode? Code
		{
			[Token(Token = "0x6006F0F")]
			[Address(RVA = "0xB98B", Offset = "0xB98B", VA = "0xB98B", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F10")]
			[Address(RVA = "0xB98C", Offset = "0xB98C", VA = "0xB98C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F11")]
		[Address(RVA = "0xB98D", Offset = "0xB98D", VA = "0xB98D")]
		public DefaultSystemDisconnectResolver(IGameRestart gameRestart)
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Application_Managers_DefaultSystemDisconnectResolver___ctor
		               (undefined4 param1,char *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a81e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_DisconnectCode__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_DisconnectCode__get_HasValue__);
		    DAT_ram_00a5a81e = '\x01';
		  }
		  uVar1 = 1;
		  if (((*param2 != '\0') && (iVar2 = *(int *)(param2 + 4), iVar2 != 1)) &&
		     (((iVar2 == 2 || (((iVar2 == 3 || (iVar2 == 4)) || (iVar2 == 5)))) ||
		      ((iVar2 == 6 || (iVar2 != 7)))))) {
		    uVar1 = (uint)(iVar2 - 9U < 2);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x00014430 File Offset: 0x00012630
		[Token(Token = "0x6006F12")]
		[Address(RVA = "0xB98E", Offset = "0xB98E", VA = "0xB98E")]
		public bool IsReConnectAllowed(DisconnectCode? code)
		{
		/* --- GHIDRA: IsReConnectAllowed ---
		void Core_Application_Managers_DefaultSystemDisconnectResolver__IsReConnectAllowed
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a81f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_DefaultSystemDisconnectResolver__Resolve_d__7___
		              );
		    DAT_ram_00a5a81f = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  local_c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_Conveyor__Execute_d__14_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_DefaultSystemDisconnectResolver__Resolve_d__7___
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F13")]
		[Address(RVA = "0xB98F", Offset = "0xB98F", VA = "0xB98F", Slot = "6")]
		public void Resolve(IConnectionManage connection)
		{
		/* --- GHIDRA: Resolve ---
		undefined4
		Core_Application_Managers_DefaultSystemDisconnectResolver__Resolve(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  ulonglong uVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a820 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_DisconnectCode__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_DisconnectCode__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_DisconnectCode__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6564);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13781);
		    DAT_ram_00a5a820 = '\x01';
		  }
		  uVar5 = *(ulonglong *)(param1 + 0xc);
		  if (DAT_ram_00a5a81e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_DisconnectCode__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_DisconnectCode__get_HasValue__);
		    DAT_ram_00a5a81e = '\x01';
		  }
		  iVar4 = Core_GameLocalization_TypeInfo;
		  uVar3 = 0;
		  uVar2 = 0;
		  if (((((uVar5 & 0xff) != 0) && (iVar1 = (int)(uVar5 >> 0x20), uVar3 = uVar2, iVar1 != 1)) &&
		      (((iVar1 == 2 || (((iVar1 == 3 || (iVar1 == 4)) || (iVar1 == 5)))) ||
		       ((iVar1 == 6 || (iVar1 != 7)))))) && (1 < iVar1 - 9U)) {
		    if ((*(ulonglong *)(param1 + 0xc) & 0xff) == 0) {
		      uVar3 = 1;
		    }
		    else {
		      iVar1 = (int)(*(ulonglong *)(param1 + 0xc) >> 0x20);
		      if (iVar1 == 2) {
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar3 = func_ii_7508(StringLiteral_13780,1,0,1,0,0,0,0);
		        Core_Application_Managers_DefaultSystemDisconnectResolver__TryNotify(iVar4,uVar3,iVar4);
		        uVar3 = 1;
		      }
		      else if ((((iVar1 == 3) || (iVar1 == 4)) ||
		               ((iVar1 == 5 ||
		                ((((iVar1 == 6 || (iVar1 == 7)) || (iVar1 == 8)) || ((iVar1 == 9 || (iVar1 == 10))))
		                )))) || (iVar1 != 0xb)) {
		        iVar4 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		        UI_Windows_Alert__Show(iVar4,0);
		        local_8 = *(undefined8 *)(param1 + 0xc);
		        uVar3 = func_ii_1081(System_Nullable_DisconnectCode__TypeInfo,&local_8);
		        uVar3 = func_ii_4419(StringLiteral_6564,uVar3,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar3 = func_ii_7508(uVar3,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar4 + 0x1c) = uVar3;
		        UI_Windows_UnityInstantiator___ctor(iVar4,0);
		        uVar3 = 1;
		      }
		      else {
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar3 = func_ii_7508(StringLiteral_13781,1,0,1,0,0,0,0);
		        Core_Application_Managers_DefaultSystemDisconnectResolver__TryNotify(iVar4,uVar3,iVar4);
		        uVar3 = 1;
		      }
		    }
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x00014448 File Offset: 0x00012648
		[Token(Token = "0x6006F14")]
		[Address(RVA = "0xB990", Offset = "0xB990", VA = "0xB990", Slot = "7")]
		public bool TryNotify()
		{
		/* --- GHIDRA: TryNotify ---
		void Core_Application_Managers_DefaultSystemDisconnectResolver__TryNotify
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a821 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    DAT_ram_00a5a821 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(param2,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                    );
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar1,0,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x24) = uVar1;
		  UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F15")]
		[Address(RVA = "0xB991", Offset = "0xB991", VA = "0xB991")]
		private void ShowAlert(string description)
		{
		}

		// Token: 0x04003A08 RID: 14856
		[Token(Token = "0x4003A08")]
		[FieldOffset(Offset = "0x8")]
		private readonly IGameRestart _gameRestart;
	}
}
