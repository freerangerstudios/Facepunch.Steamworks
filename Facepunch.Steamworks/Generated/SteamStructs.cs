using System;
using System.Runtime.InteropServices;
using System.Linq;
using Steamworks.Data;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct SteamIPAddress_t
	{
		internal SteamIPType Type; // m_eType ESteamIPType
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPackSize )]
	internal struct FriendGameInfo_t
	{
		internal GameId GameID; // m_gameID CGameID
		internal uint GameIP; // m_unGameIP uint32
		internal ushort GamePort; // m_usGamePort uint16
		internal ushort QueryPort; // m_usQueryPort uint16
		internal ulong SteamIDLobby; // m_steamIDLobby CSteamID
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct FriendSessionStateInfo_t
	{
		internal uint IOnlineSessionInstances; // m_uiOnlineSessionInstances uint32
		internal byte IPublishedToFriendsSessionInstance; // m_uiPublishedToFriendsSessionInstance uint8
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct servernetadr_t
	{
		internal ushort ConnectionPort; // m_usConnectionPort uint16
		internal ushort QueryPort; // m_usQueryPort uint16
		internal uint IP; // m_unIP uint32
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPackSize )]
	internal struct gameserveritem_t
	{
		internal servernetadr_t NetAdr; // m_NetAdr servernetadr_t
		internal int Ping; // m_nPing int
		[MarshalAs(UnmanagedType.I1)]
		internal bool HadSuccessfulResponse; // m_bHadSuccessfulResponse bool
		[MarshalAs(UnmanagedType.I1)]
		internal bool DoNotRefresh; // m_bDoNotRefresh bool
		internal string GameDirUTF8() => System.Text.Encoding.UTF8.GetString( GameDir, 0, System.Array.IndexOf<byte>( GameDir, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] // byte[] m_szGameDir
		internal byte[] GameDir; // m_szGameDir char [32]
		internal string MapUTF8() => System.Text.Encoding.UTF8.GetString( Map, 0, System.Array.IndexOf<byte>( Map, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] // byte[] m_szMap
		internal byte[] Map; // m_szMap char [32]
		internal string GameDescriptionUTF8() => System.Text.Encoding.UTF8.GetString( GameDescription, 0, System.Array.IndexOf<byte>( GameDescription, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] // byte[] m_szGameDescription
		internal byte[] GameDescription; // m_szGameDescription char [64]
		internal uint AppID; // m_nAppID uint32
		internal int Players; // m_nPlayers int
		internal int MaxPlayers; // m_nMaxPlayers int
		internal int BotPlayers; // m_nBotPlayers int
		[MarshalAs(UnmanagedType.I1)]
		internal bool Password; // m_bPassword bool
		[MarshalAs(UnmanagedType.I1)]
		internal bool Secure; // m_bSecure bool
		internal uint TimeLastPlayed; // m_ulTimeLastPlayed uint32
		internal int ServerVersion; // m_nServerVersion int
		internal string ServerNameUTF8() => System.Text.Encoding.UTF8.GetString( ServerName, 0, System.Array.IndexOf<byte>( ServerName, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] // byte[] m_szServerName
		internal byte[] ServerName; // m_szServerName char [64]
		internal string GameTagsUTF8() => System.Text.Encoding.UTF8.GetString( GameTags, 0, System.Array.IndexOf<byte>( GameTags, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)] // byte[] m_szGameTags
		internal byte[] GameTags; // m_szGameTags char [128]
		internal ulong SteamID; // m_steamID CSteamID
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct SteamPartyBeaconLocation_t
	{
		internal SteamPartyBeaconLocationType Type; // m_eType ESteamPartyBeaconLocationType
		internal ulong LocationID; // m_ulLocationID uint64
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct SteamParamStringArray_t
	{
		internal IntPtr Strings; // m_ppStrings const char **
		internal int NumStrings; // m_nNumStrings int32
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPackSize )]
	internal struct LeaderboardEntry_t
	{
		internal ulong SteamIDUser; // m_steamIDUser CSteamID
		internal int GlobalRank; // m_nGlobalRank int32
		internal int Score; // m_nScore int32
		internal int CDetails; // m_cDetails int32
		internal ulong UGC; // m_hUGC UGCHandle_t
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct P2PSessionState_t
	{
		internal byte ConnectionActive; // m_bConnectionActive uint8
		internal byte Connecting; // m_bConnecting uint8
		internal byte P2PSessionError; // m_eP2PSessionError uint8
		internal byte UsingRelay; // m_bUsingRelay uint8
		internal int BytesQueuedForSend; // m_nBytesQueuedForSend int32
		internal int PacketsQueuedForSend; // m_nPacketsQueuedForSend int32
		internal uint RemoteIP; // m_nRemoteIP uint32
		internal ushort RemotePort; // m_nRemotePort uint16
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct SteamUGCDetails_t
	{
		internal PublishedFileId PublishedFileId; // m_nPublishedFileId PublishedFileId_t
		internal Result Result; // m_eResult EResult
		internal WorkshopFileType FileType; // m_eFileType EWorkshopFileType
		internal AppId CreatorAppID; // m_nCreatorAppID AppId_t
		internal AppId ConsumerAppID; // m_nConsumerAppID AppId_t
		internal string TitleUTF8() => System.Text.Encoding.UTF8.GetString( Title, 0, System.Array.IndexOf<byte>( Title, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 129)] // byte[] m_rgchTitle
		internal byte[] Title; // m_rgchTitle char [129]
		internal string DescriptionUTF8() => System.Text.Encoding.UTF8.GetString( Description, 0, System.Array.IndexOf<byte>( Description, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8000)] // byte[] m_rgchDescription
		internal byte[] Description; // m_rgchDescription char [8000]
		internal ulong SteamIDOwner; // m_ulSteamIDOwner uint64
		internal uint TimeCreated; // m_rtimeCreated uint32
		internal uint TimeUpdated; // m_rtimeUpdated uint32
		internal uint TimeAddedToUserList; // m_rtimeAddedToUserList uint32
		internal RemoteStoragePublishedFileVisibility Visibility; // m_eVisibility ERemoteStoragePublishedFileVisibility
		[MarshalAs(UnmanagedType.I1)]
		internal bool Banned; // m_bBanned bool
		[MarshalAs(UnmanagedType.I1)]
		internal bool AcceptedForUse; // m_bAcceptedForUse bool
		[MarshalAs(UnmanagedType.I1)]
		internal bool TagsTruncated; // m_bTagsTruncated bool
		internal string TagsUTF8() => System.Text.Encoding.UTF8.GetString( Tags, 0, System.Array.IndexOf<byte>( Tags, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)] // byte[] m_rgchTags
		internal byte[] Tags; // m_rgchTags char [1025]
		internal ulong File; // m_hFile UGCHandle_t
		internal ulong PreviewFile; // m_hPreviewFile UGCHandle_t
		internal string PchFileNameUTF8() => System.Text.Encoding.UTF8.GetString( PchFileName, 0, System.Array.IndexOf<byte>( PchFileName, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)] // byte[] m_pchFileName
		internal byte[] PchFileName; // m_pchFileName char [260]
		internal int FileSize; // m_nFileSize int32
		internal int PreviewFileSize; // m_nPreviewFileSize int32
		internal string URLUTF8() => System.Text.Encoding.UTF8.GetString( URL, 0, System.Array.IndexOf<byte>( URL, 0 ) );
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] // byte[] m_rgchURL
		internal byte[] URL; // m_rgchURL char [256]
		internal uint VotesUp; // m_unVotesUp uint32
		internal uint VotesDown; // m_unVotesDown uint32
		internal float Score; // m_flScore float
		internal uint NumChildren; // m_unNumChildren uint32
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct SteamItemDetails_t
	{
		internal InventoryItemId ItemId; // m_itemId SteamItemInstanceID_t
		internal InventoryDefId Definition; // m_iDefinition SteamItemDef_t
		internal ushort Quantity; // m_unQuantity uint16
		internal ushort Flags; // m_unFlags uint16
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct SteamTVRegion_t
	{
		internal uint UnMinX; // unMinX uint32
		internal uint UnMinY; // unMinY uint32
		internal uint UnMaxX; // unMaxX uint32
		internal uint UnMaxY; // unMaxY uint32
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct NetAddress
	{
		internal ushort Port; // m_port uint16
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct NetIdentity
	{
		internal NetIdentityType Type; // m_eType ESteamNetworkingIdentityType
		internal int CbSize; // m_cbSize int
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct SteamNetworkingQuickConnectionStatus
	{
		internal ConnectionState State; // m_eState ESteamNetworkingConnectionState
		internal int Ping; // m_nPing int
		internal float ConnectionQualityLocal; // m_flConnectionQualityLocal float
		internal float ConnectionQualityRemote; // m_flConnectionQualityRemote float
		internal float OutPacketsPerSec; // m_flOutPacketsPerSec float
		internal float OutBytesPerSec; // m_flOutBytesPerSec float
		internal float InPacketsPerSec; // m_flInPacketsPerSec float
		internal float InBytesPerSec; // m_flInBytesPerSec float
		internal int SendRateBytesPerSecond; // m_nSendRateBytesPerSecond int
		internal int CbPendingUnreliable; // m_cbPendingUnreliable int
		internal int CbPendingReliable; // m_cbPendingReliable int
		internal int CbSentUnackedReliable; // m_cbSentUnackedReliable int
		internal long EcQueueTime; // m_usecQueueTime SteamNetworkingMicroseconds
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
		internal uint[] Reserved; // reserved uint32 [16]
		
	}
	
	[StructLayout( LayoutKind.Sequential, Pack = Platform.StructPlatformPackSize )]
	internal struct PingLocation
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)] //  m_data
		internal byte[] Data; // m_data uint8 [512]
		
	}
	
}
