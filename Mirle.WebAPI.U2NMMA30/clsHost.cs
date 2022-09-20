﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using Mirle.Def;
using Mirle.WebAPI.V2BYMA30.Function;

namespace Mirle.WebAPI.V2BYMA30
{
    public class clsHost
    {
        private CVReceiveNewBinCmd RECEIVE_NEW_BIN_CMD = new CVReceiveNewBinCmd();
        private BufferStatusQuery BufferStatusQuery = new BufferStatusQuery();
        private PutawayTransfer PutawayTransfer = new PutawayTransfer();
        private RetrieveTransfer RetrieveTransfer = new RetrieveTransfer();
        private MoveTask MoveTask = new MoveTask();
        private PositionReport PositionReport = new PositionReport();
        private BufferRoll BufferRoll = new BufferRoll();
        private TaskCancel TaskCancel = new TaskCancel();
        private LotTransferCancel LotTransferCancel = new LotTransferCancel();
        private LotPositionReport LotPositionReport = new LotPositionReport();
        private NGPositionReport NGPositionReport = new NGPositionReport();
        private CarrierReturnNext CarrierReturnNext = new CarrierReturnNext();
        private CarrierTransferComplete CarrierTransferComplete = new CarrierTransferComplete();
        private CarrierPutawayCheck CarrierPutawayCheck = new CarrierPutawayCheck();
        private CarrierPutawayComplete CarrierPutawayComplete = new CarrierPutawayComplete();
        private LotPutawayCheck LotPutawayCheck = new LotPutawayCheck();
        private LotPutawayComplete LotPutawayComplete = new LotPutawayComplete();
        private LotShelfReport LotShelfReport = new LotShelfReport();
        private CarrierShelfReport CarrierShelfReport = new CarrierShelfReport();
        private CarrierShelfRequest CarrierShelfRequest = new CarrierShelfRequest();
        private LotShelfRequest LotShelfRequest = new LotShelfRequest();
        private CarrierShelfComplete CarrierShelfComplete = new CarrierShelfComplete();
        private LotShelfComplete LotShelfComplete = new LotShelfComplete();
        private EmptyShelfQuery EmptyShelfQuery = new EmptyShelfQuery();
        private WCSCancel WCSCancel = new WCSCancel();
        private EmptyCarrierUnload EmptyCarrierUnload = new EmptyCarrierUnload();
        private PortStatusUpdate PortStatusUpdate = new PortStatusUpdate();
        private LotRetrieveComplete LotRetrieveComplete = new LotRetrieveComplete();
        private CarrierRetrieveComplete CarrierRetrieveComplete = new CarrierRetrieveComplete();
        private EmptyMagazineUnload EmptyMagazineUnload = new EmptyMagazineUnload();
        private EmptyMagazineLoadRequest EmptyMagazineLoadRequest = new EmptyMagazineLoadRequest();
        private MagazineLoadRequest MagazineLoadRequest = new MagazineLoadRequest();
        private LotRenewRequest LotRenewRequest = new LotRenewRequest();
        private EmptyESDCarrierUnload EmptyESDCarrierUnload = new EmptyESDCarrierUnload();
        private EmptyESDCarrierLoadRequest EmptyESDCarrierLoadRequest = new EmptyESDCarrierLoadRequest();
        private EQPStatusUpdate EQPStatusUpdate = new EQPStatusUpdate();
        private RemoveRackShow RemoveRackShow = new RemoveRackShow();
        private RemoveRackDown RemoveRackDown = new RemoveRackDown();
        private BlockStatusQuery BlockStatusQuery = new BlockStatusQuery();
        private ControlStatusQuery ControlStatusQuery = new ControlStatusQuery();
        private HealthCheck HealthCheck = new HealthCheck();
        private LotRetrieveTransfer LotRetrieveTransfer = new LotRetrieveTransfer();
        private NewCarrierToStage NewCarrierToStage = new NewCarrierToStage();
        private RackRequest RackRequest = new RackRequest();
        private RackTurn RackTurn = new RackTurn();
        private RemoteLocalRequest RemoteLocalRequest = new RemoteLocalRequest();
        private TransferCommandRequest TransferCommandRequest = new TransferCommandRequest();
        private BufferInitial BufferInitial = new BufferInitial();

        public CVReceiveNewBinCmd GetCV_ReceiveNewBinCmd() => RECEIVE_NEW_BIN_CMD;
        public BufferStatusQuery GetBufferStatusQuery() => BufferStatusQuery;
        public PutawayTransfer GetPutawayTransfer() => PutawayTransfer;
        public RetrieveTransfer GetRetrieveTransfer() => RetrieveTransfer;
        public MoveTask GetMoveTask() => MoveTask;
        public PositionReport GetPositionReport() => PositionReport;
        public BufferRoll GetBufferRoll() => BufferRoll;
        public TaskCancel GetTaskCancel() => TaskCancel;    
        public LotTransferCancel GetLotTransferCancel() => LotTransferCancel;  
        public LotPositionReport GetLotPositionReport() => LotPositionReport;
        public NGPositionReport GetNGPositionReport() => NGPositionReport;
        public CarrierReturnNext GetCarrierReturnNext() => CarrierReturnNext;
        public CarrierTransferComplete GetCarrierTransferComplete() => CarrierTransferComplete;
        public CarrierPutawayCheck GetCarrierPutawayCheck() => CarrierPutawayCheck;
        public CarrierPutawayComplete GetCarrierPutawayComplete() => CarrierPutawayComplete;
        public LotPutawayCheck GetLotPutawayCheck() => LotPutawayCheck;
        public LotPutawayComplete GetLotPutawayComplete() => LotPutawayComplete;
        public LotShelfReport GetLotShelfReport() => LotShelfReport;
        public CarrierShelfReport GetCarrierShelfReport() => CarrierShelfReport;
        public CarrierShelfRequest GetCarrierShelfRequest() => CarrierShelfRequest;
        public LotShelfRequest GetLotShelfRequest() => LotShelfRequest;
        public CarrierShelfComplete GetCarrierShelfComplete() => CarrierShelfComplete;
        public LotShelfComplete GetLotShelfComplete() => LotShelfComplete;
        public EmptyShelfQuery GetEmptyShelfQuery() => EmptyShelfQuery;
        public WCSCancel GetWCSCancel() => WCSCancel;
        public EmptyCarrierUnload GetEmptyCarrierUnload() => EmptyCarrierUnload;
        public PortStatusUpdate GetPortStatusUpdate() => PortStatusUpdate;
        public LotRetrieveComplete GetLotRetrieveComplete() => LotRetrieveComplete;
        public CarrierRetrieveComplete GetCarrierRetrieveComplete() => CarrierRetrieveComplete;
        public EmptyMagazineUnload GetEmptyMagazineUnload() => EmptyMagazineUnload;
        public EmptyMagazineLoadRequest GetEmptyMagazineLoadRequest() => EmptyMagazineLoadRequest;
        public MagazineLoadRequest GetMagazineLoadRequest() => MagazineLoadRequest;
        public LotRenewRequest GetLotRenewRequest() => LotRenewRequest;
        public EmptyESDCarrierUnload GetEmptyESDCarrierUnload() => EmptyESDCarrierUnload;
        public EmptyESDCarrierLoadRequest GetEmptyESDCarrierLoadRequest() => EmptyESDCarrierLoadRequest;
        public EQPStatusUpdate GetEQPStatusUpdate() => EQPStatusUpdate;
        public RemoveRackShow GetRemoveRackShow() => RemoveRackShow;
        public RemoveRackDown GetRemoveRackDown() => RemoveRackDown;
        public BlockStatusQuery GetBlockStatusQuery() => BlockStatusQuery;
        public ControlStatusQuery GetControlStatusQuery() => ControlStatusQuery;
        public HealthCheck GetHealthCheck() => HealthCheck;
        public LotRetrieveTransfer GetLotRetrieveTransfer() => LotRetrieveTransfer;
        public NewCarrierToStage GetNewCarrierToStage() => NewCarrierToStage;
        public RackRequest GetRackRequest() => RackRequest;
        public RackTurn GetRackTurn() => RackTurn;
        public RemoteLocalRequest GetRemoteLocalRequest() => RemoteLocalRequest;
        public TransferCommandRequest GetTransferCommandRequest() => TransferCommandRequest;
        public BufferInitial GetBufferInitial() => BufferInitial;

    }
}