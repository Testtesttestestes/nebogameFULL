using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Core.Application.Managers;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Platforms.WebGL.Notifications
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	public class NotificationManagerImplementation : INotificationManager, IAppManager, IBaseManager, IDisposable
	{
		// Token: 0x140000C2 RID: 194
		// (add) Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C2")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x5B33", Offset = "0x5B33", VA = "0x5B33", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x5B34", Offset = "0x5B34", VA = "0x5B34", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000C3 RID: 195
		// (add) Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C3")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x5B35", Offset = "0x5B35", VA = "0x5B35", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x5B36", Offset = "0x5B36", VA = "0x5B36", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x5B37", Offset = "0x5B37", VA = "0x5B37", Slot = "11")]
		public void Init()
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x5B38", Offset = "0x5B38", VA = "0x5B38", Slot = "12")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Platforms_WebGL_Notifications_NotificationManagerImplementation__Deinit
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b832 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11659);
		    DAT_ram_00a5b832 = '\x01';
		  }
		  return StringLiteral_11659;
		}
		*/

		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CA")]
		public string Name
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x5B39", Offset = "0x5B39", VA = "0x5B39", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x5B3A", Offset = "0x5B3A", VA = "0x5B3A", Slot = "14")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Platforms_WebGL_Notifications_NotificationManagerImplementation__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  return;
		}
		*/

		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x5B3B", Offset = "0x5B3B", VA = "0x5B3B", Slot = "4")]
		public void ScheduleNotification(int id, string title, string message, int delay, Dictionary<string, object> developerPayload, LocalNotifications channel)
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x5B3C", Offset = "0x5B3C", VA = "0x5B3C", Slot = "5")]
		public void ClearNotification(int id)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x5B3D", Offset = "0x5B3D", VA = "0x5B3D", Slot = "6")]
		public void InitChannels(IDictProvider dictProvider)
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x5B3E", Offset = "0x5B3E", VA = "0x5B3E")]
		public NotificationManagerImplementation()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Platforms_WebGL_Notifications_NotificationManagerImplementation__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b82f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b82f = '\x01';
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
		void Platforms_WebGL_Notifications_NotificationManagerImplementation__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b830 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b830 = '\x01';
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
		void Platforms_WebGL_Notifications_NotificationManagerImplementation__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b831 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b831 = '\x01';
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

}
