using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Core.Net
{
	// Token: 0x02000E8D RID: 3725
	[Token(Token = "0x2000E8D")]
	public class ProtocolCommandInfoProvider
	{
		// Token: 0x06005A92 RID: 23186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A92")]
		[Address(RVA = "0xA781", Offset = "0xA781", VA = "0xA781")]
		public void Add(Services service, Type index)
		{
		/* --- GHIDRA: Add ---
		undefined4
		Core_Net_ProtocolCommandInfoProvider__Add
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6058f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__TryGetValue__
		              );
		    DAT_ram_00a6058f = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_Enumerator_int___MoveNext
		                    (*(undefined4 *)(param1 + 8),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__TryGetValue__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x6005A93")]
		[Address(RVA = "0xA782", Offset = "0xA782", VA = "0xA782")]
		public bool TryGetInfo(int service, out ProtocolCommandInfoProvider.IInfo result)
		{
		/* --- GHIDRA: TryGetInfo ---
		void Core_Net_ProtocolCommandInfoProvider__TryGetInfo(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a60590 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Announcements_AnnouncementsCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Auchan_AuchanCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth_AuthCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_BalanceCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Cave_CaveCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Chat_ChatCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ClanIsleCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ClanWarCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ClansCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_CollectionsCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ColossusCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_CombatCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Tokenator_Commands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_Commands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_BlitzTournaments_Commands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_Commands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Competition_CompetitionCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_CraftCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_DailyQuests_DailyQuestsCommands_var);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Duel_DuelCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_EventsCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Location_LocationCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_MagicTowerCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_PortalCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_School_SchoolCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ServicesCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ShopCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_SmallGamesCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Social_SocialCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ThemeDuelCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Tournaments_TournamentCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Tree_TreeCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_TutorialCommands_var);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_var);
		    DAT_ram_00a60590 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo___ctor__
		            );
		  *(undefined4 *)(param1 + 8) = uVar1;
		  uVar1 = Protocol_Auth_AuthCommands_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar1 = func_ii_2734(uVar1,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 1;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,1,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Auth2_Commands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x2a;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x2a,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Main_MainCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 2;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,2,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_World_WorldCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 3;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,3,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Tree_TreeCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 4;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,4,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Shop_ShopCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 5;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,5,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_School_SchoolCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 7;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,7,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Cave_CaveCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 8;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,8,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Combat_CombatCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 10;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,10,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Services_ServicesCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0xb;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0xb,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Tournaments_TournamentCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0xc;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0xc,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Rating_RatingCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0xd;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0xd,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Clans_ClansCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0xe;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0xe,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_ClanIsle_ClanIsleCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0xf;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0xf,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_MagicTower_MagicTowerCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x10;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x10,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_ClanWar_ClanWarCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x11;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x11,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_SmallGames_SmallGamesCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x12;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x12,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Chat_ChatCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x13;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x13,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Events_EventsCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x14;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x14,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_BlitzTournaments_Commands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x15;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x15,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Tutorial_TutorialCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x16;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x16,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Auchan_AuchanCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x17;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x17,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Craft_CraftCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x18;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x18,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Social_SocialCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x19;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x19,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Duel_DuelCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x1a;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x1a,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Balance_BalanceCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x1b;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x1b,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Location_LocationCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x1c;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x1c,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Collections_CollectionsCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x1d;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x1d,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Boss_Commands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x1e;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x1e,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_DailyQuests_DailyQuestsCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x1f;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x1f,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Combat_CombatCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x20;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x20,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Colossus_ColossusCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x21;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x21,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Tokenator_Commands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x2c;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x2c,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Themeduel_ThemeDuelCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x2d;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x2d,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Portal_PortalCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x2e;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x2e,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Announcements_AnnouncementsCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x2f;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x2f,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  uVar1 = func_ii_2734(Protocol_Competition_CompetitionCommands_var,0);
		  if (DAT_ram_00a6058e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		    DAT_ram_00a6058e = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 8);
		  iVar2 = unnamed_function_1417(Core_Net_ProtocolCommandInfoProvider_Info_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  *(undefined4 *)(iVar2 + 8) = 0x30;
		  UnityEngine_Object__GetInstanceID
		            (uVar3,0x30,iVar2,
		             Method_System_Collections_Generic_Dictionary_int__ProtocolCommandInfoProvider_IInfo__Add__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A94")]
		[Address(RVA = "0xA783", Offset = "0xA783", VA = "0xA783")]
		public ProtocolCommandInfoProvider()
		{
		}

		// Token: 0x04003177 RID: 12663
		[Token(Token = "0x4003177")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<int, ProtocolCommandInfoProvider.IInfo> _infos;

		// Token: 0x02000E8E RID: 3726
		[Token(Token = "0x2000E8E")]
		public interface IInfo
		{
			// Token: 0x06005A95 RID: 23189
			[Token(Token = "0x6005A95")]
			string GetName(int value);
		}

		// Token: 0x02000E8F RID: 3727
		[Token(Token = "0x2000E8F")]
		public class Info : ProtocolCommandInfoProvider.IInfo
		{
			// Token: 0x06005A96 RID: 23190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A96")]
			[Address(RVA = "0xA784", Offset = "0xA784", VA = "0xA784")]
			public Info(Services service, Type index)
			{
			}

			// Token: 0x06005A97 RID: 23191 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A97")]
			[Address(RVA = "0xA785", Offset = "0xA785", VA = "0xA785", Slot = "4")]
			public string GetName(int value)
			{
				return null;
			}

			// Token: 0x04003178 RID: 12664
			[Token(Token = "0x4003178")]
			[FieldOffset(Offset = "0x8")]
			private readonly Services _service;

			// Token: 0x04003179 RID: 12665
			[Token(Token = "0x4003179")]
			[FieldOffset(Offset = "0xC")]
			private readonly Type _index;
		}
	}
}
