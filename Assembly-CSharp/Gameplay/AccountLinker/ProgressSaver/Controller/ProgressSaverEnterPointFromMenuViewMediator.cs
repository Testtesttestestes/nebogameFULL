using System;
using System.Collections.Generic;
using Core.Gameplay.Managers.Notifications.Controller;
using Gameplay.AccountLinker.Control;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.FeedbackForm.Model.Controll;
using Gameplay.UserInterface.Menu.ExternalLinks.Control;
using Gameplay.UserInterface.Menu.ExternalLinks.Model;
using Gameplay.UserInterface.Menu.ExternalLinks.View;
using Gameplay.UserInterface.Menu.Settings.Control;
using Gameplay.UserInterface.View.Menu;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.AccountLinker.ProgressSaver.Controller
{
	// Token: 0x02000E11 RID: 3601
	[Token(Token = "0x2000E11")]
	public class ProgressSaverEnterPointFromMenuViewMediator : BaseProgressSaverEnterPointViewMediator<MenuView>
	{
		// Token: 0x060057BE RID: 22462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057BE")]
		[Address(RVA = "0xA531", Offset = "0xA531", VA = "0xA531")]
		public ProgressSaverEnterPointFromMenuViewMediator(ProgressSaverModel model, ProgressSaverEvents events, ProgressSaverController controller, MenuWindow.MenuWindowArgs.SelectedTab selectedTab, IReadOnlyDictionary<string, string> payload)
		{
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060057BF RID: 22463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057C0 RID: 22464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EB")]
		public override MenuView View
		{
			[Token(Token = "0x60057BF")]
			[Address(RVA = "0xA532", Offset = "0xA532", VA = "0xA532", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057C0")]
			[Address(RVA = "0xA533", Offset = "0xA533", VA = "0xA533", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C1")]
		[Address(RVA = "0xA534", Offset = "0xA534", VA = "0xA534")]
		private void OnTabChanged()
		{
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C2")]
		[Address(RVA = "0xA535", Offset = "0xA535", VA = "0xA535")]
		private void OnTabChanged(OptionsMenuButton optionsMenuButton)
		{
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C3")]
		[Address(RVA = "0xA536", Offset = "0xA536", VA = "0xA536", Slot = "21")]
		protected override void ResetView()
		{
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C4")]
		[Address(RVA = "0xA537", Offset = "0xA537", VA = "0xA537", Slot = "22")]
		protected override void SetupView()
		{
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		[Token(Token = "0x60057C5")]
		[Address(RVA = "0xA538", Offset = "0xA538", VA = "0xA538")]
		private MenuWindow.MenuWindowArgs.SelectedTab ButtonId2Tab(uint buttonId)
		{
			return MenuWindow.MenuWindowArgs.SelectedTab.undefined;
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C6")]
		[Address(RVA = "0xA539", Offset = "0xA539", VA = "0xA539")]
		private void SwitchTab(MenuWindow.MenuWindowArgs.SelectedTab tab)
		{
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C7")]
		[Address(RVA = "0xA53A", Offset = "0xA53A", VA = "0xA53A")]
		private void OptionMenuButtonClickedEventHandler(OptionsMenuButton dic)
		{
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C8")]
		[Address(RVA = "0xA53B", Offset = "0xA53B", VA = "0xA53B", Slot = "23")]
		protected override void ValidateShowProgressButton()
		{
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057C9")]
		[Address(RVA = "0xA53C", Offset = "0xA53C", VA = "0xA53C")]
		public void ShowSaveProgress()
		{
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CA")]
		[Address(RVA = "0xA53D", Offset = "0xA53D", VA = "0xA53D")]
		public void ShowSettings()
		{
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CB")]
		[Address(RVA = "0xA53E", Offset = "0xA53E", VA = "0xA53E")]
		public void ShowNotifications()
		{
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CC")]
		[Address(RVA = "0xA53F", Offset = "0xA53F", VA = "0xA53F")]
		public void ShowFeedbackForm()
		{
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CD")]
		[Address(RVA = "0xA540", Offset = "0xA540", VA = "0xA540")]
		public void ShowExternalLinks()
		{
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CE")]
		[Address(RVA = "0xA541", Offset = "0xA541", VA = "0xA541")]
		private void ClearMediators()
		{
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CF")]
		[Address(RVA = "0xA542", Offset = "0xA542", VA = "0xA542", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04002F86 RID: 12166
		[Token(Token = "0x4002F86")]
		[FieldOffset(Offset = "0x18")]
		private MenuWindow.MenuWindowArgs.SelectedTab _selectedTab;

		// Token: 0x04002F87 RID: 12167
		[Token(Token = "0x4002F87")]
		[FieldOffset(Offset = "0x1C")]
		private IReadOnlyDictionary<string, string> _payload;

		// Token: 0x04002F88 RID: 12168
		[Token(Token = "0x4002F88")]
		[FieldOffset(Offset = "0x20")]
		private AccountLinkerViewMediator _accountLinkerViewMediator;

		// Token: 0x04002F89 RID: 12169
		[Token(Token = "0x4002F89")]
		[FieldOffset(Offset = "0x24")]
		private ProgressSaverViewMediator _progressSaverViewMediator;

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[FieldOffset(Offset = "0x28")]
		private SettingsViewMediator _settingsViewMediator;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[FieldOffset(Offset = "0x2C")]
		private GameNotificationSettingsWindowMediator _notificationSettingsMediator;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x30")]
		private FeedbackFormViewMediator _feedbackFormViewMediator;

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x34")]
		private ExternalLinksMediator _externalLinksMediator;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x38")]
		private ExternalLinksModel _externalLinksModel;

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x3C")]
		private ExternalLinksEvents _externalLinksEvents;

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<MenuWindow.MenuWindowArgs.SelectedTab, int> _tabsMap;
	}
}
