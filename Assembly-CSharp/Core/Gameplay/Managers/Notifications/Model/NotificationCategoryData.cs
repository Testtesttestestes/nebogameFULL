using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Notifications.Model
{
	// Token: 0x020011AD RID: 4525
	[Token(Token = "0x20011AD")]
	public class NotificationCategoryData
	{
		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06006B83 RID: 27523 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006B84 RID: 27524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015EC")]
		public NotificationCategoryDic NotificationCategoryDic
		{
			[Token(Token = "0x6006B83")]
			[Address(RVA = "0xB67E", Offset = "0xB67E", VA = "0xB67E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006B84")]
			[Address(RVA = "0xB67F", Offset = "0xB67F", VA = "0xB67F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06006B85 RID: 27525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015ED")]
		public List<NotificationGroupData> Groups
		{
			[Token(Token = "0x6006B85")]
			[Address(RVA = "0xB680", Offset = "0xB680", VA = "0xB680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06006B86 RID: 27526 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[Token(Token = "0x170015EE")]
		public uint SortOrder
		{
			[Token(Token = "0x6006B86")]
			[Address(RVA = "0xB681", Offset = "0xB681", VA = "0xB681")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06006B87 RID: 27527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015EF")]
		public string Title
		{
			[Token(Token = "0x6006B87")]
			[Address(RVA = "0xB682", Offset = "0xB682", VA = "0xB682")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B88")]
		[Address(RVA = "0x2210", Offset = "0x2210", VA = "0x2210")]
		public NotificationCategoryData(NotificationCategoryDic notificationCategoryDic, List<NotificationGroupData> groups)
		{
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x00013DD0 File Offset: 0x00011FD0
		[Token(Token = "0x6006B89")]
		[Address(RVA = "0xB683", Offset = "0xB683", VA = "0xB683")]
		public bool TryGetGroup(uint groupId, out NotificationGroupData result)
		{
		/* --- GHIDRA: TryGetGroup ---
		void Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData__TryGetGroup
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a682 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo);
		    DAT_ram_00a5a682 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x040038C6 RID: 14534
		[Token(Token = "0x40038C6")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<uint, NotificationGroupData> _groupsDictionary;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		undefined4
		Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData__get_SortOrder
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_NotFoundInDictsUtil___cctor(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Title ---
		undefined4
		Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData__get_Title
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a681 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__NotificationGroupData__TryGetValue__
		              );
		    DAT_ram_00a5a681 = '\x01';
		  }
		  uVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x10),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_uint__NotificationGroupData__TryGetValue__
		                    );
		  return uVar1;
		}
		*/

}
