using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B4 RID: 4532
	[Token(Token = "0x20011B4")]
	public abstract class AbstractLocalNotificationScheduler : AbstractBaseNotificationScheduler
	{
		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06006BAF RID: 27567 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006BB0 RID: 27568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015FB")]
		private protected LocalNotificationDic NotificationDic
		{
			[Token(Token = "0x6006BAF")]
			[Address(RVA = "0xB6A1", Offset = "0xB6A1", VA = "0xB6A1")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6006BB0")]
			[Address(RVA = "0xB6A2", Offset = "0xB6A2", VA = "0xB6A2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x00013E30 File Offset: 0x00012030
		[Token(Token = "0x170015FC")]
		protected override bool IsNotificationEnabled
		{
			[Token(Token = "0x6006BB1")]
			[Address(RVA = "0xB6A3", Offset = "0xB6A3", VA = "0xB6A3", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB2")]
		[Address(RVA = "0xB6A4", Offset = "0xB6A4", VA = "0xB6A4", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB3")]
		[Address(RVA = "0xB6A5", Offset = "0xB6A5", VA = "0xB6A5", Slot = "9")]
		protected override void HandleDispose()
		{
		/* --- GHIDRA: HandleDispose ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__HandleDispose
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  if ((ulonglong)param2 == (longlong)iVar1) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x11c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB4")]
		[Address(RVA = "0xB6A6", Offset = "0xB6A6", VA = "0xB6A6", Slot = "10")]
		protected override void OnSettingsChanged(uint notificationId)
		{
		}

		// Token: 0x06006BB5 RID: 27573
		[Token(Token = "0x6006BB5")]
		protected abstract void HandleSettingsChanged();

		// Token: 0x06006BB6 RID: 27574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB6")]
		[Address(RVA = "0xB6A7", Offset = "0xB6A7", VA = "0xB6A7")]
		protected AbstractLocalNotificationScheduler()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_NotificationDic ---
		uint Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__set_NotificationDic
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a692 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a692 = '\x01';
		  }
		  param1_00 = (int *)param1[3];
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x260);
		        goto code_r0x81252bee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x34);
		code_r0x81252bee:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = *(int *)(iVar4 + 0x14);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  if (DAT_ram_00a5a67e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__get_Item__);
		    DAT_ram_00a5a67e = '\x01';
		  }
		  uVar3 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar4 + 0x10),uVar3,
		                     Method_System_Collections_Generic_Dictionary_uint__uint__get_Item__);
		  iVar4 = func_ii_8735(iVar4,uVar3,iVar4);
		  return (uint)*(byte *)(iVar4 + 0x10);
		}
		*/


		/* --- GHIDRA: get_IsNotificationEnabled ---
		void Core_Gameplay_Managers_Notifications_Controller_Schedulers_AbstractLocalNotificationScheduler__get_IsNotificationEnabled
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a693 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a693 = '\x01';
		  }
		  param1_00 = (int *)param1[3];
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81252ced;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81252ced:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		  iVar4 = Core_Extensions_Dict_DictExt__GetUIElementsDic(uVar3,param2_00,0);
		  param1[4] = iVar4;
		  return;
		}
		*/

}
